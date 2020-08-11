using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using RestSharp;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Web;

namespace MusicPlayer
{
    public partial class MainWindow : Form
    {
        TokenData data; // null - переменная никуда не указывает

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e) // Registration button click
        {
            if (tb_password.Text == tb_repeat_password.Text)
            {
                RestClient client = new RestClient("http://213.59.157.203/MusicXBackend/");
                // RestClient - сущность которая отправляет на сервер запросы

                RestRequest request = new RestRequest("api/register");
                // RestRequest - и есть сам запрос.
                // Любой Http запрос состоит из Заголовков (Headers) и Тела (Body)
                request.AddHeader("Content-Type", "application/json"); // Говорим серверу, что мы отправили данные типа JSON (application/json)
                // request.AddHeader("ИМЯ ЗАГОЛОВКА ЗАПРОСА", "ЗНАЧЕНИЕ ЗАГОЛОВКА ЗАПРОСА");
                RegisterData register = new RegisterData(tb_login.Text, tb_password.Text, tb_name.Text, tb_lastname.Text);
                // Тело запроса - обычная строка в виде json
                request.AddJsonBody(register); // Устанавливаем тело запроса - json строку с нашими данными
                IRestResponse response = client.Post(request); // POST запрос и получаем ответ в переменную IRestResponse response
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    MessageBox.Show("Ваш пользователь был зарегистрирован!");
                }
                else
                {
                    MessageBox.Show("Не удалось зарегистрировать пользователя!  Код ошибки: " + response.StatusCode);
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            }
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            
            if (tb_auth_password.Text != "")
            {
                RestClient client = new RestClient("http://213.59.157.203/MusicXBackend/");
                RestRequest request = new RestRequest("/api/authenticate");
                request.AddHeader("Content-Type", "application/json");
                AuthData auth = new AuthData(tb_auth_login.Text, tb_auth_password.Text);
                request.AddJsonBody(auth);
                IRestResponse response = client.Post(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    #region Комментарии
                    // Тело ответа: response.Content
                    // Выглядит вот так:
                    // { "token" : "dfkjdshfkjsdhfjkdshfkdsb" }
                    // Нужно забрать токен без всякого мусора (то есть без фигурных скрбок. самого слова token, ...)
                    // Чтобы забрать нормальнные данные - нам необходимо ДЕСЕРИАЛИЗОВАТЬ JSON в С# объект
                    // Для десереализации мы используем JsonConvert.DeserializeObject(строка JSON)

                    // Для метода DeserializeObject необходимо уточнить тип, куда он будет десериализовывать данные.
                    // Для уточнения используется <T>.
                    // То есть нам нужно написать: JsonConvert.DeserializeObject<TokenData>(response.Content);
                    // <T> означает "Уточнить тип данных", используется в List<> чтобы уточнить, какой тип должен находиться внутри листа. 
                    #endregion
                    data = JsonConvert.DeserializeObject<TokenData>(response.Content);
                    MessageBox.Show("Авторизация удалась! Токен: " + data.token);
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
                else
                {
                    MessageBox.Show("Не удалось авторизоваться!  Код ошибки: " + response.StatusCode);
                }
            }
        }

        private void btn_create_playlist_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Сначала авторизируйся!");
            }
            else
            {
                RestClient client = new RestClient("http://213.59.157.203/MusicXBackend/");
                RestRequest request = new RestRequest("/api/playlist");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + data.token);
                PlaylistData playlist = new PlaylistData(tb_playlist_name.Text, tb_description.Text, ch_private.Checked);
                request.AddJsonBody(playlist);
                IRestResponse response = client.Post(request);
                MessageBox.Show("Код ответа: " + response.StatusCode + ", тело ответа: " + response.Content);
            }
        }

        private void btn_getPlaylists_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("http://213.59.157.203/MusicXBackend/");
            RestRequest request = new RestRequest("/api/playlists");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + data.token);
            IRestResponse response = client.Get(request);
            MessageBox.Show("Тело: " +  response.Content);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                PlaylistContent playlistContent = JsonConvert.DeserializeObject<PlaylistContent>(response.Content);
                //MessageBox.Show(playlistContent.content[0]);
                for (int i = 0; i < playlistContent.content.Count; i++)
                {
                    lb_playlists.Items.Add(playlistContent.content[i].name);
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e) // Во время загрузки формы
        {
            RestClient client = new RestClient("http://213.59.157.203/MusicXBackend/");
            RestRequest request = new RestRequest("/api/authenticate");
            request.AddHeader("Content-Type", "application/json");
            AuthData auth = new AuthData("rtu1", "rtu1");
            request.AddJsonBody(auth);
            IRestResponse response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("JSON: " + response.Content);
                data = JsonConvert.DeserializeObject<TokenData>(response.Content);
                MessageBox.Show("Авторизация удалась! Токен: " + data.token);
            }

        }
    }
}

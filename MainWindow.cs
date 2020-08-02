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

namespace MusicPlayer
{
    public partial class MainWindow : Form
    {
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
                RegisterData register = new RegisterData();
                register.username = tb_login.Text;
                register.password = tb_password.Text;
                register.name = tb_name.Text;
                register.lastname = tb_lastname.Text;
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
                AuthData auth = new AuthData();
                auth.username = tb_auth_login.Text;
                auth.password = tb_auth_password.Text;
                request.AddJsonBody(auth);
                IRestResponse response = client.Post(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
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
                    TokenData data = JsonConvert.DeserializeObject<TokenData>(response.Content);
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
    }
}

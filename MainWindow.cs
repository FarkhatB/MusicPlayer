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
                string json = "{" +
                    "\"username\": \"" + tb_login.Text + "\"," +
                    "\"password\": \"" + tb_password.Text + "\"," +
                    "\"name\": \" " + tb_name.Text + "\", " +
                    "\"lastname\": \"" + tb_lastname.Text + "\"" +
                "}"; // Тело запроса - обычная строка в виде json
                request.AddJsonBody(json); // Устанавливаем тело запроса - json строку с нашими данными
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
    }
}

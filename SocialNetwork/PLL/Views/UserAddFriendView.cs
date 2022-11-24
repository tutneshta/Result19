using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class UserAddFriendView
    {
        UserService service;

        public UserAddFriendView(UserService service)
        {
            this.service = service;
        }

        public void Show(User user)
        {
            try
            {
                AddFriendDate addFriendDate = new AddFriendDate();

                Console.WriteLine("Введите email друга:");

                addFriendDate.Email = Console.ReadLine();
                addFriendDate.UserId = user.Id;

                service.AddFriend(addFriendDate);

                SuccessMessage.Show("Друг добавлен!");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении друга");
            }
        }
    }
}
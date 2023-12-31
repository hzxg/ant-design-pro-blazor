using AntDesign.Pro.Template.Models;
using AntDesign.Pro.Template.Services;
using Microsoft.AspNetCore.Components;

namespace AntDesign.Pro.Template.Pages.User
{
    public partial class Login
    {
        private readonly LoginParamsType _model = new LoginParamsType();

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IAccountService AccountService { get; set; }

        [Inject] public MessageService Message { get; set; }
        public async void HandleSubmit()
        {

            if (_model.UserName == "123" && _model.Password == "123")
            {
                NavigationManager.NavigateTo("/");
                return;
            }

            if (_model.UserName == "user" && _model.Password == "ant.design") NavigationManager.NavigateTo("/");
        }


    }
}
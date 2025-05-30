using System;

namespace Quiz_Application.Controllers
{
    public class AdminController
    {
        private readonly FormAdmin view;

        public AdminController(FormAdmin view)
        {
            this.view = view;
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            view.BtnAddSoalClicked += OnBtnAddSoalClicked;
            view.BtnEditSoalClicked += OnBtnEditSoalClicked;
            view.BtnDeleteSoalClicked += OnBtnDeleteSoalClicked;
            view.BtnViewSoalClicked += OnBtnViewSoalClicked;
        }

        private void OnBtnAddSoalClicked(object? sender, EventArgs e)
        {
            var formAddSoal = new FormAddSoal();
            formAddSoal.Show();
        }

        private void OnBtnEditSoalClicked(object? sender, EventArgs e)
        {
            var formEditSoal = new FormEditSoal();
            formEditSoal.Show();
        }

        private void OnBtnDeleteSoalClicked(object? sender, EventArgs e)
        {
            var formDeleteSoal = new FormDeleteSoal();
            formDeleteSoal.Show();
        }

        private void OnBtnViewSoalClicked(object? sender, EventArgs e)
        {
            var formViewSoal = new FormViewSoal();
            formViewSoal.Show();
        }
    }
}

using LessonOne.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Zagolovok okna
        private string _Title = "Мой первый проект";
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set
            {
                if (Equals(_Title, value)) return;
                _Title = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Status Program
        private string _Status = "Готово";
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        #endregion
    }
}

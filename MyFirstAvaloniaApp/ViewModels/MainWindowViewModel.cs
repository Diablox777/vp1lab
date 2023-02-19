using Avalonia.Media;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Reactive;
using MyFirstAvaloniaApp.Models;


namespace MyFirstAvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        string _mainText = "";
        RomanNumberExtend n1;
        bool _error;

        public void Set_text(string x)
        {
            _mainText = x;
        }

        public string Get_text()
        {
            return _mainText;
        }

        private bool Error
        {
            get => _error;
            set
            {
                if (value) SetInvalidExpression();
                else if (!value && _error) MainText = "";
                _error = value;
            }
        }
        char op;
        public string MainText
        {
            get
            {
                return _mainText;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _mainText, value);
            }
        }

        public void WriteChar(string x)
        {
            Error = false;
            MainText += x;
        }
        public void CalcAnswer()
        {
            var x = new RomanNumberExtend(MainText);
            try
            {
                if (op == '+')
                    MainText = (x + n1).ToString();
                else if (op == '-')
                    MainText = (n1 - x).ToString();
                else if (op == '/')
                    MainText = (n1 / x).ToString();
                else if (op == '*')
                    MainText = (n1 * x).ToString();
            }
            catch (RomanNumberException ex)
            {
                Error = true;
            }

        }
        public void Clear()
        {
            MainText = "";
            n1 = null;

        }
        private void SetInvalidExpression() => MainText = "ERROR";
        public void DoOperator(char op)
        {
            try
            {
                n1 = new RomanNumberExtend(MainText);
                this.op = op;
            }
            catch (RomanNumberException ex)
            {
                Error = true;
            }
            if (!Error) MainText = "";
        }
    }
}

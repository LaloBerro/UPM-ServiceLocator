using System;

namespace ServiceLocatorPattern.Examples
{
    public interface ICounterView
    {
        Action OnAddNumberClick { get; set;}
        void ShowCount(string count);
    }
}
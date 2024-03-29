﻿using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.PageObjects
{
    public class PersonPage
    {
        private const string PageUrl = "http://localhost:5000/";

        private IWebElement RandomNameButton => _browserInteractions.WaitAndReturnElement(By.Id("randomName"));

        private IWebElement NameLabel => _browserInteractions.WaitAndReturnElement(By.Id("HelloLabel"));

        private readonly IBrowserInteractions _browserInteractions;
        public PersonPage(IBrowserInteractions browserInteractions) =>
            _browserInteractions = browserInteractions;

        internal string CheckName()
        {
            return NameLabel.Text;
        }

        public void Goto() => _browserInteractions.GoToUrl(PageUrl);

        public void ChangeName() => RandomNameButton.Click();

    }
}

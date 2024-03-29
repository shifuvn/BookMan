﻿using System;
using BookMan.ConsoleApp.Framework;

namespace BookMan.ConsoleApp.Views
{
    /// <summary>
    /// View create new book class (internal)
    /// </summary>
    internal class BookCreateView : ViewBase
    {
        /// <summary>
        /// Constructor init create book view
        /// </summary>
        public BookCreateView() { }

        /// <summary>
        /// Create book render method
        /// </summary>
        public override void Render()
        {
            ViewHelp.WriteLine("Create new book", ConsoleColor.Green);

            string title = ViewHelp.InputString("Title ");
            string authors = ViewHelp.InputString("Authors ");
            string publisher = ViewHelp.InputString("publisher ");
            int year = ViewHelp.InputInt("Year ");
            int edition = ViewHelp.InputInt("Edition ");
            bool reading = ViewHelp.InputBool("Reading ");

            var req = "do create ? " +
                      $"title = {title} & authors = {authors} & publisher = {publisher} & year = {year} & edition = {edition}";
            _router.Forward(req);
            
            Console.WriteLine();
        }
        
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Serv1ce
{
    public class AllBookInfo
    {
        public void GetInfo()
        {
            Menu menu = new Menu();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < menu.listBooks.Length / 4; j+=3)
                {
                    Console.WriteLine(menu.listBooks[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
        public void SearchBook(string bookName)
        {
            Menu menu = new Menu();
            bool IsThisBook = false;
            int i_value = 0, j_value = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < menu.listBooks.Length / 4; j+=3)
                {
                    if (menu.listBooks[i, j].ToLower() == bookName.ToLower())
                    {
                        i_value = i;
                        j_value = j;
                        IsThisBook = true;
                    }
                }
                Console.WriteLine();

            }
            if (IsThisBook == true)
            {
                Console.WriteLine("Name: " + menu.listBooks[i_value, j_value]);
                Console.WriteLine("Price: " + menu.listBooks[i_value, j_value + 1]);
                Console.WriteLine("Author: " + menu.listBooks[i_value, j_value + 2]);
                Console.WriteLine("Name: " + menu.listBooks[i_value, j_value + 3]);
            }
            else
            {
                Console.WriteLine("This is not book");
            }
        }
    }
}

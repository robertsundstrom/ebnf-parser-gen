﻿/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 2014-08-01
 * Time: 23:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using GrammarExplorer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace GrammarExplorer
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();

            DataContext = new MainViewModel();
		}
    }
}
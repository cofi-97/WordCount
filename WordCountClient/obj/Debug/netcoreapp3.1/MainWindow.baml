   M S B A M L   `   `   `  ����J  FWordCountClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WordCountClientWordCountClient  5   	        WordCountClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WordCountClient     5   	     � Title$  
MainWindow��5   	   $	��238��6   $	��509��6)   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� .��6   
From File:6   �� 5   
   -   5        $��fromFIleBtn��5   3   $��1��6   $��0,0,0,10q�6!   .��6`   	From File6k   �� 5   
   $��1��6   .��6   From Database:6-   �� 5   
   -   5        $��fromDatabaseBtn��5   @   $��1��6   $��1��6   $��0,0,0,10q�6.   .��6u   From Database6�   �� 5   
   $��2��6   .��6   From input:6*   �� 5   
   -   5         ��Name$ textBoxInput��5      $��2��6(   $��1��65    �� AcceptsReturn$
 True��6E   �� 5   
   -   5        $��fromInputBtn��5   .   $��3��6   $��1��6   .��6]   
From Input6i   �� 5   
   -   5         ��Name$ wordCountLbl��5      $��4��6&   $��0��63   .��6C   Word Count:6P   5      5      
   M S B A M L   `   `   `  ����E  ABudget-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Budget_WPF
Budget_WPF  5   	       Budget_WPF.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Budget_WPF     5   	     � Title$  Бюджет��5	   	   $	��480��6   $	��480��6(   $	��600��65   $	��600��6D   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.5* �6   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$
 Date��5       � Language$ ru-RU�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Дата��5       "  MaterialDesignFilledDatePicker#��[  5      $��0��5       $��0��6   $��2��6*   $��
10 10 10 5q�6>      FirstDayOfWeek$ Monday=�6R   6j   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$
 Data��5!      $��1��5"      $��0��6   $��7��6*   $��10 5 5 5q�6;      
IsReadOnly$
 True��5#      	   CanUserSortColumns$	 False��5$      
   CanUserAddRows$
 False��5%         CanUserDeleteRows$ False��5&         CanUserResizeColumns$ False��5'         CanUserResizeRows$ False��5(         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5)      -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 4 2 2 2q�5*         ColumnHeaderPadding$ 4 2 2 2q�5+      6I   �� 5,   
   -   5         ��Name$ 	Note_name��5,        MaterialDesignFilledTextBox#��[ 5-      $ Имя записи��5.      $��1��5/      $��1��6   $��5 5 10 5q�6*   �� 50   
   -   5         ��Name$
 Type��52      $��2��51      $��1��6   $��5 5 10 5q�6*      MaterialDesignFilledComboBox#��[ 53      $ Тип записи��55      $
��Auto��56      {�54      ��  �� Path$ 	IsChecked� �� ElementName$# FilledComboBoxEnabledCheckBox��57      �� 58   
   -   5         ��Name$ Button_add_type��58       " MaterialDesignFlatDarkBgButton#��[ 59       � ToolTip$" MaterialDesignFlatDarkButton��5:      $��Добавить тип��5;      $��3��5<      $��1��6   $��5 5 10 5q�6*    � Cursor$
 Hand��6<   $��32��6J   $��Center=�6V   6q   �� 5=   
   -   5        $	 Sum��5=      #��[ 5>      $ Сумма денег��5?      $��4��5@      $��1��6   $��5 5 10 5q�6*   �� 5A   
   -   5        $ 
Button_add��5A      #��[ 5B      $" MaterialDesignFlatDarkButton��5C      $#��Добавить запись��5D      $��6��5E      $��1��6   $��5 5 10 5q�6*   $
 Hand��6<   $��32��6J   $��Center=�6V   6q   �� 5F   
   -   5        $ Button_change��5F      #��[ 5G      $" MaterialDesignFlatDarkButton��5H      $#��Изменить запись��5I      $��7��5J      $��1��6   $��5 5 10 5q�6*   $
 Hand��6<   $��32��6J   $��Center=�6V   6q   �� 5K   
   -	   5        $ Button_delete��5K      #��[ 5L      $" MaterialDesignFlatDarkButton��5M      $!��Удалить запись��5N      $��8��5O      $��1��6   $��5 5 10 5q�6*   $
 Hand��6<   $��32��6J   $��Center=�6V   6q   #  MaterialDesignThemes.Wpf.Card  5P   
   $��8��5Q      $��0��6   $��10 0 5 0q�6*     PrimaryHueLightBrush#���  5R       " PrimaryHueLightForegroundBrush#���  5S      $
��Auto��5T      .��5U      �� -
   5         ��Name$ Total��5U      $��SemiBold"�5V      $��Center=�5W      $��Center=�5X      $��18(�5Y      
�������$��Итог: 0��5[      5\      5]      5^      
   M S B A M L   `   `   `  ????I  EEducationTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EducationTests.PagesEducationTests.Pages  5      *    $EducationTests.Pages.UserProfilePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:EducationTests.Pages     5        N? Title$  UserProfilePage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??50 ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      $??* ?6   .+?5   
   ]? $??2??6   $??1??6!   $??2??61   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ UserProfileGrid??5         AutoGenerateColumns .     CanUserAddRows .     CanUserSortColumns .     HorizontalGridLinesBrush
 ?????
???????   CanUserReorderColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$!
 Название теста??6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ??  ?? Path$ name_test.name?6i     5      $
 Статус теста??6)   $ * 6_    6?   ?? $ status?6_     5      $
 Результат??6)   $ * 6^    6<   ?? $ progress?6^     5      $
 
Время??6)   $ * 6V    68   ?? $
 date?6V   5      ?? 5       $??1??6   $??2??6+   $??3??68   $??Stretch=?6B   5!      ?? 5#   
   $??2??6   $??0??6"    ?? Orientation$ Vertical=?62   .+?5$      ?? -   5         ??Name$ ReturnMainButton??5$      $??90??6/   $??30??6:   $??Главная??6F   $??
0, 0, 0, 0q?6X   6l   ?? 5%      -   5        $ ShowResultButton??5%      $??90??6/   $??30??6:   $#??Результат теста??6F   $??
0, 5, 0, 0q?6`   6t   ?? 5&      -   5        $ DeleteRecordButton??5&      $??90??61   $??30??6<   $!??Удалить запись??6H   $??
0, 5, 0, 0q?6a   6u   ?? 5'      -   5        $ ExitAccountButton??5'      $??90??60   $??30??6;   $??
Выйти??6G   $??
0, 5, 0, 0q?6W   6k   5(      ?? 5*   
   $??0??6   $??0??6"   $ 
Horizontal=?62   $??Center=?6K   .+?5+      ?? -   5         ??Name$ NameTextBlock??5+      $??Имя:??6/   $??28(?6;    ?? Padding$ 5,0,0,0q?6I   $
??Bold"?6[   5,      ?? 5.   
   $??0??6   $??1??6"   $ 
Horizontal=?62   $??Center=?6K   .+?5/      ?? -   5        $ UserNameTextBlock??5/      $??28(?63   $
??Bold"?6A   50      51      52      
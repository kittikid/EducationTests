   M S B A M L   `   `   `  ????I  EEducationTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EducationTests.WindowsEducationTests.Windows  5   	   +    %EducationTests.Windows.UserTestResult   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EducationTests.Windows     5   	     ? Title$  UserTestResult??5   	   $	??400??6    $	??300??6-   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6    ?? Orientation$ 
Horizontal=?6"   $??Center=?6;   .+?5      ?? -   5         ??Name$ TestNameTextBlock??5      $??Имя теста??63   $??24(?6D   $
??Bold"?6R    ?? Padding$ 
5, 0, 0, 0q?6d   5      ]? 5   
   $??1??6   $??1??6!   $??2??61   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ UserResultGrid??5         AutoGenerateColumns .     CanUserAddRows .     HorizontalGridLinesBrush
 ?????
???????	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Вопрос??6)      CanUserSort .     Width5  /System.Windows.Controls.DataGridLengthConverter$	 10* 6~   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   ??  ?? Path$ question_table.question?6~     5      $
 
Ответ??6)    .  $	 10* 6    6L   ?? $ answer_table.name_answers?6   5      ?? 5      $??1??6   $??1??6+   $??3??68   $??Stretch=?6B   5      5      5      
   M S B A M L   `   `   `  ????I  EEducationTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EducationTests.PagesEducationTests.Pages  5      '    !EducationTests.Pages.PassTestPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:EducationTests.Pages     5        N? Title$  PassTestPage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??70 ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $??0??6.   .+?5      ?? -   5         ??Name$ TestNameLabel??5      $??
Тест: ??6+   $??24(?6<   $
??Bold"?6J   5      ?? 5   
   $ 
Horizontal=?6   $??1??6.   .+?5      ?? $
??Auto=?6   .??5      ?? -   5         ??Name$ QuestionNameTextBlock??5      $
??Wrap=?6;   $	??580??6O   $??18(?6[    ?? Padding$ 10q?6i   5      5      ]? 5   
   $??2??6   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
AnswerGrid??5         AutoGenerateColumns .     ColumnHeaderHeight$ 0Q?6G   	   HorizontalGridLinesBrush
	 ?????
   CanUserAddRows
 .  
???????   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ??  ?? Path$ name_answers?6O   5#      5$      ?? 5&   
   $ 
Horizontal=?6   $??3??6.   $??Right=?6;   .+?5'      ?? -   5        $ NumQuestionTextBLock??5'      $ 10q?66   $	??Hsd??6C   
???   ?$??18(?6a   5(      ?? 5*   
   $ 
Horizontal=?6   $??3??6.   $??Center=?6;   .+?5+      ?? -   5         ??Name$ SelectAnswerButton??5+      $??Выбрать??61   $??30??5,      $	??100??6!   $??5,5,5,5q?6-   $??5,5,0,5q?6?   6P   ?? 5.      -   5        $ NextQuestionButton??5.      $??Дальше??61   $??30??5/      $	??100??6!   $??5,5,5,5q?6-   $??5,5,0,5q?6?   6P   50      ?? 52   
   $ 
Horizontal=?6   $??3??6.   $
??Left=?6;   $??
0, 0, 0, 0q?6V   .+?53      ?? -   5        $ 
TimerLabel??53      $??00:00??6(   $??10q?68   $??18(?6E   54      ?? 56   
   $ 
Horizontal=?6   $??0??6.   $??Right=?6;   .+?57      ?? -   5        $ ExitTestButton??57      $??
Выйти??6-   $??30??58      $	??100??6!   $??5,5,5,5q?6-   $??5,5,5,5q?6?   6P   59      5<      5=      
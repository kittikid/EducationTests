   M S B A M L   `   `   `  ????I  EEducationTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EducationTests.PagesEducationTests.Pages  5      &     EducationTests.Pages.EndTestPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:EducationTests.Pages     5        N? Title$  EndTestPage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $??0??6.   .+?5      ?? -   5         ??Name$ InfoTextBlock??5      $!??Вы прошли тест!??6/   $??24(?6F   $
??Bold"?6T    ?? Padding$ 
5, 5, 0, 0q?6f   5      ?? 5   
   $ 
Horizontal=?6   $??1??6.   .+?5      ?? -   5        $ TimeTextBlock??5      $)??#Время прохождения: ??6/   $??24(?6J   $
??Bold"?6X   $ 
5, 5, 0, 0q?6j   ?? 5      -   5        $ NumTimeTextBlock??5      $??24(?62   $
??Bold"?6@   $ 
5, 5, 0, 0q?6R   5      ?? 5   
   $ 
Horizontal=?6   $??2??6.   .+?5      ?? -   5        $ ResultTextBlock??5      $!??Ваш результат: ??61   $??24(?6H   $
??Bold"?6V   $ 
5, 5, 0, 0q?6h   ?? 5      -   5        $ NumResultTextBlock??5      $??24(?64   $
??Bold"?6B   $ 
5, 5, 0, 0q?6T   5      ?? 5!   
   $ 
Horizontal=?6   $??3??6.   $??Center=?6;   .+?5"      ?? -   5         ??Name$ RepeatTestButton??5"      $??Повтроить??6/   $??30??5#      $	??100??6!   $??5,5,5,5q?6-   $??5,5,0,5q?6?   6P   ?? 5%      -   5        $ EndTestButton??5%      $??Завершить??6,   $??30??5&      $	??100??6!   $??5,5,5,5q?6-   $??5,5,0,5q?6?   6P   5'      5)      5*      
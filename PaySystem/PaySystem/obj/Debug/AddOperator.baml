   M S B A M L   `   `   `  ????D  @PaySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PaySystem	PaySystem  5          PaySystem.AddOperator   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:PaySystem     5        N? Title$  AddOperator??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??20 ?6   6*   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      $??20 ?6   6*    ? ColumnDefinitions 5   
   ?? 5      $??20 ?6   6,   ?? 5      6!   ?? 5      6!   ?? 5      $??20 ?6   6,   .+?5   
   ?? $??1??6   $??1??6    $??Id??6-   $??18(?6:   $??Center=?6H   $??Center=?6e   6?   ?? 5   
   $??1??6   $??2??6    $??Phone??6-   $??18(?6=   $??Center=?6K   $??Center=?6h   6?   ?? 5   
   $??1??6   $??3??6    $
??Logo??6-   $??18(?6<   $??Center=?6J   $??Center=?6g   6?   ?? 5    
   $??1??6   $??4??6    $
??Name??6-   $??18(?6<   $??Center=?6J   $??Center=?6g   6?   ?? 5!   
   $??1??6   $??5??6    $??Precent??6-   $??18(?6?   $??Center=?6M   $??Center=?6j   6?   ?? 5"   
   $??1??6   $??6??6    $??
CreateDate??6-   $??18(?6B   $??Center=?6P   $??Center=?6m   6?   ?? 5#   
   -   5         ??Name$ tbxId??5#   ;   $??2??6   $??1??6"   $??10q?6/   {?.  6^   ?? 5$   
   -   5        $ tbxPhone??5$   ;   $??2??6   $??2??6"   $??10q?6/   6O   ?? 5%   
   -   5        $ tbxLogo??5%   ;   $??2??6   $??3??6"   $??10q?6/   6N   ?? 5&   
   -   5        $ tbxName??5&   ;   $??2??6   $??4??6"   $??10q?6/   6N   ?? 5'   
   -   5        $ 
tbxPrecent??5'   ;   $??2??6   $??5??6"   $??10q?6/   6Q   (  "System.Windows.Controls.DatePicker  5(   
   -   5          Name$ dpCreateDate??5(   >   $??2??6   $??6??6%   $??10q?62   6V   ?? 5)   
   -   5         ??Name$ btnAdd??5)      $??2??6!   $??7??61   $??10q?6>   6L   5*      5+      
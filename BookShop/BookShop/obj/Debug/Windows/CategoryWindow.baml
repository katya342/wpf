   M S B A M L   `   `   `  ????C  ?BookShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BookShopBookShop  5   	       BookShop.CategoryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BookShop     5   	     ? Title$  CategoryWindow??5   	   $	??450??6    $	??800??6-   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??50 ?6   6*   ?? 5      $	??100 ?6   6+   ?? 5      $??50 ?6   6*   ?? 5      $??70 ?6   6*   ?? 5      $	??100 ?6   6+   .+?5   
   ?? $??0??6   .+?5      ?? $??ADD CATEGORY??6   $
??Bold"?6,   6@   ? 5      $??1??6    ? Orientation$ 
Horizontal=?6%   .+?5      ?? -   5         ??Name$ 	tbxcatAdd??5      $	??150??6-   6;   ?? 5      -   5        $	??Add??5      $??50??6'   $??5 0 0 0q?62   6Z   5      5      ?? 5   
   $??1??6   .+?5      ?? $??ADD SUB - CATEGORY??6   $
??Bold"?61   6E   ?? 5      $??PARENT CATEGORY : ??6   5       ?? 5!      -   5         ??Name$ cmbBox??5!   >   $	??200??6   $
??Left=?6#    ?? DisplayMemberPath$ SubName??6N    ?? SelectedValuePath$ 	Parent_id??6j   5#      5%      ?? 5&   
   $??2??6   .+?5'      ?? $??SUB - CATEGORY??6   6/   ? 5(      .+?5)      ?? -   5        $ 	txtBoxAdd??5)   &   $	??150??6   6;   ?? 5*      -   5        $	??Add??5*      $??50??6'   $??5 0 0 0q?62   6^   5+      5-      ?? 5/   
   $??3??6   .+?50      ?? $??Delete category??6   $
??Bold"?6/   6C   ? 51      $??3??6   .+?52      ?? -   5        $ 	cmbBoxDel??52   B   $	??200??6   $
??Left=?6'   $
 Name??53      $ Id??63   55      ?? 56      -   5        $??Delete??56      $??5 0 0 0q?6*   6W   57      58      ?? 5:   
   $??4??6   .+?5;      ?? $??Delete sub category??6   $
??Bold"?62   6F   ? 5<      $??3??6   .+?5=      ?? -   5        $ cmbBoxDelSub??5=   B   $	??200??6   $
??Left=?6'   $ SubName??6X   $ SubId??6t   5?      ?? 5@      -	   5        $??Delete??5@      $??5 0 0 0q?6*   6[   5A      5B      5D      5E      
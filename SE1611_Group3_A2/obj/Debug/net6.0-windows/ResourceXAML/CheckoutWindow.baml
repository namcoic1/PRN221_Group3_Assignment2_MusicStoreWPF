   M S B A M L   `   `   `  ????K  GSE1611_Group3_A2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SE1611_Group3_A2.ResourceXAMLSE1611_Group3_A2.ResourceXAML  5   	   2    ,SE1611_Group3_A2.ResourceXAML.CheckoutWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SE1611_Group3_A2.ResourceXAML     5   	     ? Title$  CheckoutWindow??5   	   $	??450??6    $	??800??6-   
????ح?.??5
      ?? -   5         ??Name$
 root??5
      .+?5   
   ?? $??Center=?6   $??	0 20 20 0q?61   $??30(?6D   $
??Bold"?6R   	Invoice6m   ?? 5   
    ?? Orientation$ 
Horizontal=?6   $??Center=?6.   .+?5      ?? $	??380??6   $??0 0 20 0q?6%   .+?5      ?? .+?5      ?? $??
FirstName:??6   63   ?? 5      -   5         ??Name$ txtFirstName??5      66   5      ?? 5      .+?5      ?? $??	LastName:??6   62   ?? 5      -   5        $ txtLastName??5      65   5      ?? 5      .+?5      ?? $??Address:??6   61   ?? 5      -   5        $ 
txtAddress??5      64   5      ?? 5      .+?5      ?? $??City:??6   6.   ?? 5      -   5        $ txtCity??5      61   5      ?? 5      .+?5      ?? $??State:??6   6/   ?? 5       -   5        $ txtState??5       62   5!      ?? 5"      .+?5#      ?? $??Country:??6   61   ?? 5$      -   5        $ 
txtCountry??5$      64   5%      5&      ?? 5'      $	??380??6   .+?5(      ?? .+?5)      ?? $??Phone:??6   6/   ?? 5*      -   5        $ txtPhone??5*      62   5+      ?? 5,      .+?5-      ?? $??Email:??6   6/   ?? 5.      -	   5        $ txtEmail??5.      62   5/      ?? 50      $??Center=?6   .+?51      ?? $??Total:??6   $
??Bold"?6-   6A   ?? 52      -
   5         ??Name$ txtTotal??52   3   
???????$	??150??6E   $
??Bold"?6Q   6e   53      ?? 54      $??Center=?6   .+?55      ?? $??Cash:??6   $
??Bold"?6,   6@   ?? 56      -   5        $ txtCash??56      $	??150??6/   $
??Bold"?6;   6O   57      ?? 58      $??Center=?6   .+?59      ?? $??Remains:??6   $
??Bold"?6/   6C   ?? 5:      -   5        $ 
txtRemains??5:      $	??150??62   $
??Bold"?6>   6R   5;      5<      5=      ?? 5>   
   $??Center=?6   $??0 30 0 0q?62   $ 
Horizontal=?6D   .+?5?      ?? -   5        $
??Save??5?      $??60??6$   $??0 0 20 0q?6/   6Z   ?? 5@      -   5        $??Cancel??5@      $??60??6&   6H   5A      5B      5C      
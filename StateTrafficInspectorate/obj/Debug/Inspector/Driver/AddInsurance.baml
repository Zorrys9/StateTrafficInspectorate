   M S B A M L   `   `   `  ����S  OStateTrafficInspectorate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:StateTrafficInspectorate.Inspector.Driver)StateTrafficInspectorate.Inspector.Driver  5   	   <    6StateTrafficInspectorate.Inspector.Driver.AddInsurance   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:StateTrafficInspectorate.Inspector.Driver     5   	     � Title$/  )Регистрация страховки��5   	      StyleWindow#��[  6'   $��373.083��6L   $��396.88��6]   .��5	      � -   5        .+�5
   
   �� $%��VIN код автомобиля��6   $
��Left=�6-   $��10,6,0,0q�6H   $	��Top=�6Z   �� 5   
   -   5         ��Name$	 VIN��5       �� 	MaxLength$ 17��6   $
��Left=�6.   $��23��6I   $��
193,10,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��176��6�   6�   �� 5   
   $%��Дата регистрации��6   $
��Left=�6+   $��	10,42,0,0q�6F   $	��Top=�6Y   �� 5   
   $,��&Дата истечения срока��6   $
��Left=�6/   $��	10,78,0,0q�6J   $	��Top=�6]   �� 5   
   $��
Серия��6   $
��Left=�6    $��
10,114,0,0q�6;   $	��Top=�6O   �� 5   
   $��
Номер��6   $
��Left=�6    $��156,114,0,0q�6;   $	��Top=�6P   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DateInsurance��5      $
��Left=�6,   $��
193,47,0,0q�6G   $	��Top=�6[   $	��176��6s     5   
   -   5        $ 
DateExpire��5      $
��Left=�6)   $��
193,81,0,0q�6D   $	��Top=�6X   $	��176��6p   �� 5   
   -   5        $ Number��5      $
��Left=�6"   $��23��6=   $��243,119,0,0q�6I   $
 Wrap=�6^   $��363454��6r   $	��Top=�6�   $	��126��6�   �� 5   
   -   5        $ Series��5      $
��Left=�6"   $��23��6=   $��
69,119,0,0q�6I   $
 Wrap=�6]   $
��3634��6q   $	��Top=�6}   $��82��6�   �� 5   
   $��Тип страховки��6   $
��Left=�6(   $��
10,150,0,0q�6C   $	��Top=�6W   �� 5   
   $��
Сумма��6   $
��Left=�6    $��
10,193,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $	 Sum��5      $
��Left=�6   $��23��6:   $��130,197,0,0q�6F   $
 Wrap=�6[   $
��3634��6o   $	��Top=�6{   $	��239��6�   �� 5   
   -   5         ��Name$
 Type��5      $
��Left=�6!    �� SelectedIndex$ 0��6<   $��131,154,0,0q�6N   $	��Top=�6c   $	��238��6{   �� 5   
   -	   5         ��Name$	 Add��5   #   {�.  $&�� Зарегистрировать��60   $
��Left=�6K   $��
10,242,0,0q�6f   $	��Top=�6z   $	��195��6�   $��58��6�   6�   �� 5   
   -
   5        $
 Back��5      $��
Назад��6   $
��Left=�6/   $��228,242,0,0q�6J   $	��Top=�6_   $	��141��6w   $��58��6�   6�   5      5      
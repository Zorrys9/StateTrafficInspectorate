   M S B A M L   `   `   `  ����S  OStateTrafficInspectorate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:StateTrafficInspectorate.Inspector.Driver)StateTrafficInspectorate.Inspector.Driver  5   	   <    6StateTrafficInspectorate.Inspector.Driver.ChangeDriver   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:StateTrafficInspectorate.Inspector.Driver     5   	   -   5          � Title$8  2Смена владельца автомобиля��5   	   $��511.2��6,   $	��806��6;      StyleWindow#��[  6H   .��5	      � .+�5
   
   �� $%��VIN код автомобиля��6   $
��Left=�6-   $��	10,10,0,0q�6H   $	��Top=�6[   �� 5   
   $%��Текущий владелец��6   $
��Left=�6+   $��	10,60,0,0q�6F   $	��Top=�6Y   �� 5   
   $%��Будущий владелец��6   $
��Left=�6+   $��
10,165,0,0q�6F   $	��Top=�6Z   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ CurrentDriverList��5      $
��Left=�6.   $��69��6I   $��	10,96,0,0q�6U   $	��Top=�6h   $	��780��6�   6�     5   
   -   5        $ NextDriverList��5      $
��Left=�6+   $	��109��6F   $��
10,202,0,0q�6S   $	��Top=�6g   $	��780��6   �� 5   
   $��ФИО водителя��6   $
��Left=�6'   $��
10,320,0,0q�6B   $	��Top=�6V   �� 5   
   -   5         ��Name$	 VIN��5       �� 	MaxLength$ 17��6   $
��Left=�6.   $��29��6I   $��
190,12,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��330��6�   6�   �� 5   
   -   5         ��Name$ Change��5   #   {�.  $'��!Сменить владельца��63   $
��Left=�6O   $��362,404,0,0q�6j   $	��Top=�6   $	��202��6�   $��59��6�   6�   �� 5   
   -   5        $
 Back��5      $��
Назад��6   $
��Left=�6/   $��586,404,0,0q�6J   $	��Top=�6_   $	��202��6w   $��59��6�   6�   �� 5   
   -   5        $ 
NameDriver��5      $
��Left=�6&   $��29��6A   $��
10,356,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��778��6�   6�   5      5      
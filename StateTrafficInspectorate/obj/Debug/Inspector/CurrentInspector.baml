   M S B A M L   `   `   `  ����S  OStateTrafficInspectorate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:StateTrafficInspectorate.Inspector"StateTrafficInspectorate.Inspector  5   	   9    3StateTrafficInspectorate.Inspector.CurrentInspector   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:StateTrafficInspectorate.Inspector     5   	     � Title$  CurrentInspector��5   	   $��266.264��6"   $��729.802��63      StyleWindow#��[  6C   .��5	      � -   5        .+�5
   
   �� $�� ��6   $
��Left=�6   $��	10,10,0,0q�66   $	��Top=�6I   �� 5   
   $��Фамилия��6   $
��Left=�6"   $��8,10,0,0q�6=   $	��Top=�6O   �� 5   
   $��Имя��6   $
��Left=�6   $��	10,46,0,0q�69   $	��Top=�6L   �� 5   
   $��Отчество��6   $
��Left=�6#   $��8,82,0,0q�6>   $	��Top=�6P   �� 5   
   $��
Логин��6   $
��Left=�6    $��
10,118,0,0q�6;   $	��Top=�6O   �� 5   
   $��Пароль��6   $
��Left=�6!   $��
10,154,0,0q�6<   $	��Top=�6P   �� 5   
   $��Должность��6   $
��Left=�6$   $��
10,190,0,0q�6?   $	��Top=�6S   �� 5   
   -   5         ��Name$ 	FirstName��5       �� 	MaxLength$ 50��6%   $
��Left=�64   $��23��6O   $��
105,14,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��245��6�   �� 5   
   -   5        $ LastName��5      $ 50��6$   $
��Left=�63   $��23��6N   $��
105,50,0,0q�6Z   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��245��6�   �� 5   
   -   5        $ 
Patronymic��5      $ 50��6&   $
��Left=�65   $��23��6P   $��
105,86,0,0q�6\   $
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��245��6�   �� 5   
   -   5        $ Login��5      $ 50��6!   $
��Left=�60   $��23��6K   $��105,122,0,0q�6W   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��245��6�   �� 5   
   -   5        $ Password��5      $ 50��6$   $
��Left=�63   $��23��6N   $��105,158,0,0q�6Z   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��245��6�   �� 5   
   -   5         ��Name$ Position��5      $
��Left=�6%    �� SelectedIndex$ 0��6@   $��120,190,0,0q�6R   $	��Top=�6g   $	��230��6   �� 5   
   -   5         ��Name$
 Back��5      $��
Назад��6   $
��Left=�6/   $��589,125,0,0q�6J   $	��Top=�6_   $	��123��6w   $��60��6�   6�   �� 5   
   $'��!Паспортные данные��6   $
��Left=�6,   $��
390,46,0,0q�6G   $	��Top=�6[   �� 5   
   $��Дата рождения��6   $
��Left=�6(   $��
390,10,0,0q�6C   $	��Top=�6W   �� 5   
   $��
Серия��6   $
��Left=�6    $��
390,86,0,0q�6;   $	��Top=�6O   �� 5   
   $��
Номер��6   $
��Left=�6    $��
553,86,0,0q�6;   $	��Top=�6O   �� 5   
   -	   5        $ PasportSeries��5      $ 4��6)   $
��Left=�67   $��23��6R   $��
450,90,0,0q�6^   $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��100��6�   �� 5   
   -
   5        $ PasportNumber��5      $ 6��6)   $
��Left=�67   $��23��6R   $��
612,90,0,0q�6^   $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��100��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	DateBirth��5      $
��Left=�6(   $��
518,11,0,0q�6C   $	��Top=�6W   $	��142��6o   5       5!      
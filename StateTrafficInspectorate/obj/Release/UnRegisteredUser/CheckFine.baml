   M S B A M L   `   `   `  ���� S  OStateTrafficInspectorate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:StateTrafficInspectorate.UnRegisteredUser)StateTrafficInspectorate.UnRegisteredUser  9    3StateTrafficInspectorate.UnRegisteredUser.CheckFine   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Ilocal7clr-namespace:StateTrafficInspectorate.UnRegisteredUser       � Title$%  Проверка штрафов��$	��382��$	��784��   StyleWindow#��[  .��� ���	#FFDFF0FA.+��� $��Проверять по :��$��16(�$
��Left=�$��	10,10,0,0q�$	��Top=��� -    ��Name$ 
FilterName��$��18(�$
��Left=�$��
135,10,0,0q�$	��Top=�$	��185��$��31��.@��� $��VIN коду��$
��Left=�$	��183���� $'��!Паспорту водителя��$
��Left=�$	��183���� $��ВУ водителя��$
��Left=�$	��183���� $	��VIN��$��16(�$
��Left=�$��	10,55,0,0q�$	��Top=��� $
��Left=�$��18(�$��31��$��	75,55,0,0q� �� TextWrapping$
 Wrap=�$��1234567890ABCDKLW��$	��Top=�$	��245���� -    ��Name$ Check��$��Проверить��$��18(�$
��Left=�$��
340,10,0,0q�$	��Top=�$	��175��$��60���� -   $
 Back��$��
Назад��$��18(�$
��Left=�$��
560,10,0,0q�$	��Top=�$	��185��$��60��&   System.Windows.Controls.DataGrid  -     Name$ FineList��$
��Left=�$	��209��$��	10,91,0,0q�$	��Top=�$	��735��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��  $ Автомобиль��  $ Сумма штрафа��  $ Причина��  $% Дата штрафования��  $0 *Крайний срок погашения��
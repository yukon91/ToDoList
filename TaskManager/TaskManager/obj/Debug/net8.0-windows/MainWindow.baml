   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager  5   	       TaskManager.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TaskManager     5   	   
����� �  � Title$  	To-Do App��5	   	   $	��311��6   $	��545��6(   .��5      � $��0,0,0,31q�6   .+�5   
   �� -   5        $��TaskTextBox��5      $
��Left=�5      $��	65,10,0,0q�5      $	��Top=�5      $	��236��5      $��30��5       �� TextAlignment$ Center=�5      �� 5   
   -   5        $��	AddButton��5      $��Lägg till uppgift��5      $
��Left=�5      $	��Top=�5      $��94��5      $��30��5      $��
306,10,0,0q�5      
�������$��Medium"�5      �� 5   
   -   5        $��TasksListBox��5      $
��Left=�5      $��65,51,0,-20q�5      $	��434��5       �� 5!   
   -   5        $��RemoveButton��5!      $��Ta bort uppgift��5"      $
��Left=�5#      $	��Top=�5$      $��94��5%      $��30��5&      $��
405,10,0,0q�5'      
�������$��Medium"�5*       J� RenderTransformOrigin$ 0.343,0.628&�6%   5+      5,      
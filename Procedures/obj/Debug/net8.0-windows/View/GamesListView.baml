   M S B A M L   `   `   `  ����  
Procedures#    Procedures.View.GamesListView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��3��5      $��30��5      $	��Top=�5      $��Center=�5      $��0��5      $��0��5       ��5!      �� *SearchKeyword+�� 5#   
   $��3��5$      $��0��5%      $��30��5&      $	��Top=�5'      $��
🔍Search��5(      $��5,0,0,5q�5)      ��5*      �� *SearchCommand+o� 51   
   $��0��52      $��5��53      
���   �$��2q�55      $��Center=�56      $��Center=�57      .@�58      m� $	��⇩��6   .@�59      m� ��6   �� *EnterPlayer.Login+m� 5:      $��Update account��6   m� 5;      $��Remove account��6    m� Command 63   �� *RemoveAccCommand+m� 5<      $
��Exit��6   5=      5?      � 5A   
   $��1��6   $��0��5B      $��2��5C      $��6��5D        5F      �� 5G      �� 5H      .+�5K      &   System.Windows.Controls.DataGrid  -   5          Name$ 	ItemsList��5O      $��0��5K         AutoGenerateColumns$ False��5N      ��5L      �� *	GamesList+ �� SelectedItem 5M      �� *SelcetedGame+   Columns 5P      0  *System.Windows.Controls.DataGridTextColumn  5Q      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
IsReadOnly$
 True��6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *Id+6L     5R      $
 Name��6)   $
 True��6P   	 67   �� *Name+6P     5S      $ Genre��6)   $
 True��6R   	 68   �� *Genre+6R     5T      $ 	Publisher��6)   $
 True��6Z   	 6<   �� *	Publisher+6Z     5U      $ Price��6)   $
 True��6R   	 68   �� *Price+6R     5V      $ Description��6)   $
 True��6^   	 6>   �� *Description+6^   5X      �� 5[      -   5        
 ��Name$
 SearchedItems��5[   &   $��1��6   $��Stretch=�6c   ��6=   �� *SearchedItems+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5\      +  %Microsoft.Xaml.Behaviors.EventTrigger  5]         	EventName$ MouseDoubleClick��6%   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5^      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 60   �� *DescriptionCommand+   CommandParameter 6W   �� *SelectedItem+ �� ElementName$ SearchedItems��5_      ��5a      �� 5b      .R�5c      ]� $��False��6$   .+�5d      �� $
��Left=�6(   $��5q�6X   ��6>   �� *
ItemName+6X   5e      5f      5h      5k      � 5n   
   $��4��6   $��0��6   $��6��6,     5o      �� 5p      �� 5q      �� 5r      �� 5s      .+�5v      �� $��0��5w      $��Add Game��5x      $��30��5y      $��5q�5z      ��5{      �� *AddGameCommand+�� 5}      $��1��5~      $��Description��5      $��30��5�      $��5q�5�      ��5�      �� *DescriptionCommand+��5�      �� $ SearchedItems�� �� Path$ SelectedItem��� 5�      $��2��5�      $��Delete Game��5�      $��30��5�      $��5q�5�      ��5�      �� *
DeleteGame+��5�      �� $ 	ItemsList��$ SelectedItem��� 5�      $��3��5�      $
��Exit��5�      $��30��5�      $��5q�5�      ��5�      �� *UpdateItemCommand+��5�      �� $ 	ItemsList��$ SelectedItem�5�      5�      5�      
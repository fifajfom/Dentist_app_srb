   M S B A M L   `   `   `  ����O  KOrdinacijaMihajlovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OrdinacijaMihajlovicOrdinacijaMihajlovic  5   	       OrdinacijaMihajlovic.Zub   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OrdinacijaMihajlovic     5   	   -   5          �Name$
  ZubW��5   	    � Title$	 Zub��5   	   $��311.22��6   $��470.498��6%    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z    � Icon$ teeth-icon.png��6�    � 	Resources 5	       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ res/hover.xaml?�6%   �� 5      $ res/placeholder.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"   	 �� 
StartPoint$	 0.5,0&�63   .��5      � 
 � Color$
 	#FF231625��6    � Offset$
 0.17Q�61   � 5      $
 	#FF5A1F62��6   $ 0.993Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Zub_datagrid��5         AutoGenerateColumns .     CanUserAddRows .  $
��Left=�6�   $	��149��6�   $��	23,83,0,0q�6�   $	��Top=�6�   $	��410��6�   ��6^   �� *LoadDataBindingZubi+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6=      MinWidth$ 10Q�6I      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+5        5       $ Datum��6W   $ 10Q�6f    .  6&   �� *datum+ �� StringFormat$ dd-MM-yy��5!        5"      $ Beleška��6B   $	 400Q�6S    .  6%   �� *	beleske+5#      5(      �� 5)   
   -   5         ��Name$ ZubText��5)         placeHolder#��[  6#   
 � Tag$ Unesi belešku��6H   $
��Left=�6\   $��21��6w   $��
141,54,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��292��6�   �� 5*   
   -   5         ��Name$ Clear��5*      ���	#FFBF1B1B$��segoe)�69   $
��Bold"�6L   $��Izbriši belešku��6`   $
��Left=�6z   $��
23,240,0,0q�6�   $	��Top=�6�   $��87��6�   6�   �� 5+   
   -   5        $ 	UpdateZub��5+      
����·�$��segoe)�6A   $
��Bold"�6T   $��Sačuvaj��6h   $
��Left=�6z   $��359,240,0,0q�6�   $	��Top=�6�   $��75��6�   6�   (  "System.Windows.Controls.DatePicker  5,   
   -   5          Name$ Datum��5,       � ToolTip$ Izaberi datum��6$   $
��Left=�6<   $��
319,24,0,0q�6X   $	��Top=�6l   $	��114��6�      IsDropDownOpen .     FirstDayOfWeek$ Monday=�6�   �� 5-   
   -   5        $ ZubDugme��5-      $��
Ukloni zub��6#   $
��Left=�68   $��	25,24,0,0q�6S   $	��Top=�6f   $��99��6~   $��21��6�   $��segoe)�6�   $
��Bold"�6�   
����·�6�   �� 5.   
   -   5        $ 	ZubDugme2��5.      $��Zub je uklonjen��6$   $
��Left=�6>   $��	25,24,0,0q�6Y   $	��Top=�6l   $��99��6�   $��21��6�   $��segoe)�6�   $
��Bold"�6�   
���r���6�   �� 5/   
   -	   5        $ Refresh��5/      $��Osveži��6"   $
��Left=�63   $��138,240,0,0q�6N   $	��Top=�6c   $��75��6{   ���	#FFC8C324$��segoe)�6�   $
��Bold"�6�   �� 50   
   -
   5        $ Izmeni��50      $��Izmeni��6!   $
��Left=�62   $��247,240,0,0q�6M   $	��Top=�6b   $��75��6z   
���r���$��segoe)�6�   $
��Bold"�6�   6�   52      53      
   M S B A M L   `   `   `  ����D  @Test_code, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Test_code	Test_code  5   	   /clr-namespace:Test_code.utilTest_code.util  5   	       Test_code.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Test_code     5   	   -utilclr-namespace:Test_code.util     5   	     � Title$  
MainWindow��5	   	   $	��400��6   $	��500��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��Project:��6   $��1��6$   $��1��64   6C   �� 5   
   -   5        $��	ComboBox1��5      $��2��6$   $��2��64   $��1��6I   $	��240��6V   $
��10,0q�6b   ��6p   �� *	myProject+��5      �� 5       .R�5!      �� ��6    �� *Name+5"      5$      �� 5&   
   -   5        $��3��5&      $��3��6   $	��120��6.   $��30��6:   $��Print As PDF��6F   5(      �� 5+   
   -   5        $��NoteListView��5+      $��1��6(   $��2��68   $��3��6E   $
��0,10q�6Y   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5,      !   Test_code.util.GridViewSort   AutoSort$
 True��5-         ShowSortGlyph$
 True��5.      ��5+   g   �� *	myNotes+ �� View 50      �� 51      .P�52      �� $	��Key��6J    �� Width$ 40��6W      PropertyName$	 Key��6b   	 �� DisplayMemberBinding	 6%   �� *Key+6�   �� 53      $��Content��6N   $	 190��6_   $ Content��6l   	 6%   �� *	Content+
 �� CellTemplate
 54      �� 55      .R�56   "   ��  ��Name$ content��6*   ��6;   �� *	Content+57      59      �� 5:      $
��Type��6K   $ 80��6Y   $
 Type��6e   	 6%   �� *Type+6�   �� 5;      $
��Prio��6K   $ 40��6Y   	 6%   �� *Prio+6g   �� 5<      $��Action��6%   $ 84��65   
 5=      �� 5>      .R�5?   "   ��  ��Name$ deleteButton��6)   -   5        $��Delete��5?   ?   $��70��6�   ��6k   �� 6�   5@      5B      5C      5E      5H      5I      
   M S B A M L   `   `   `  ����F  BSpectraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SpectraViewSpectraView  5   	       SpectraView.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SpectraView     5   	     � WindowStyle$
  None=�5   	    � Title$ SepectraView��5	   	   $	��350��6   $	��500��6+   .��5
      �  � RowDefinitions 5   
   �� 5      $	�� 30 �6   �� 5      $�� Auto �6   .+�5      o� -   5         o�Name$
 menu��5      $��22��6   $	��Top=�6%   $��0,0,-8,0q�6=   $��0��6O   .@�5   
   m� $��Datei��6   $��55��6"   $��17��6-   .@�5      m� -   5        $��Öffnen��5      $
��Left=�6'   $	��140��6B   5      m� 5      $��
Bearbeiten��6   $
��Left=�6+   $	��140��6F   m� 5      $��	Speichern��6   $
��Left=�6*   $	��140��6E   m� 5      $��Exportieren��6   $
��Left=�6,   $	��140��6G   5      m� 5   
   $��Einstellungen��6   .@�5      m� $
��Maus��6   $
��Left=�6%   $	��140��6@   m� 5      $��Hintergrundbild��6   $
��Left=�60   $	��140��6K   5      5      �� 5   
   -   5         ��Name$ DisplayPanel��5      $��1��6+   �� 5   
   -   5         ��Name$ 
hauptImage��5      $
��Left=�6$   $	��205��6?   $��75,19,0,-223q�6L   $��1��6b   $	��Top=�6o   $	��345��6�   �� 5   
   -   5         ��Name$ slider��5      $
��Left=�6!   $��20��6<   $��75,239,0,-257q�6H   $��1��6_   $	��Top=�6l   $	��345��6�   6�   5       5#      
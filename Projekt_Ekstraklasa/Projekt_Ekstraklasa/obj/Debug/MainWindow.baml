   M S B A M L   `   `   `  ����N  JProjekt_Ekstraklasa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Projekt_EkstraklasaProjekt_Ekstraklasa  5   	   $    Projekt_Ekstraklasa.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Projekt_Ekstraklasa     5   	     � Title$  Ekstraklasa��5   	   $��384.071��6   $��844.026��6.   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��Druzyny��5
      $��	0,45,0,33q�6"      AutoGenerateColumns .  J� RenderTransformOrigin$ 0.5,0.5&�6�   $��4��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.228Q�6$   �� 5      T� 5       T� X$ -0.512Q�6)   5      5      �� 5   
   -   5        $��
SaveButton��5      $��Zapisz��6<   $��407,308,0,0q�6M   � 5   
   $
��Left=�6   $��25��6*   $��	10,10,0,0q�66   $	��Top=�6I   $	��792��6a   $��4��6m    � ColumnDefinitions 5      �� 5      $	��74* �6#   �� 5      $
��423* �6#   .+�5      �� -   5         ��Name$ ButtonDruzyny��5      $��Druzyny��6H   $
��Left=�6Z   $	��Top=�6u   $��52��6�   $��25��6�   �� 5      -   5        $ ButtonPilkarze��5      $��	Piłkarze��6K   $
��Left=�6^   $	��Top=�6y   $��52��6�   $��25��6�   $��2��6�   $��57,0,0,0q�6�   �� 5      -   5        $ ButtonBramki��5      $��Bramki��6G   $
��Left=�6X   $	��Top=�6s   $��52��6�   $��25��6�   $��	114,0,0,0q�6�   $��2��6�   �� 5      -   5        $ ButtonKartki��5      $��Kartki��6G   $
��Left=�6X   $	��Top=�6s   $��52��6�   $��25��6�   $��53,0,0,0q�6�   $��1��6�   �� 5      -   5        $ ButtonSedziowie��5      $��
Sędziowie��6M   $
��Left=�6a   $	��Top=�6|   $��62��6�   $��25��6�   $��	110,0,0,0q�6�   $��1��6�   �� 5       -   5        $ ButtonSpotkania��5       $��	Spotkania��6M   $
��Left=�6a   $	��Top=�6|   $��57��6�   $��25��6�   $��	177,0,0,0q�6�   $��1��6�   �� 5!      -	   5        $ ButtonTrenerzy��5!      $��Trenerzy��6K   $
��Left=�6^   $	��Top=�6y   $��52��6�   $��25��6�   $��	239,0,0,0q�6�   $��1��6�   $ 0.798,0.544&�6�   �� 5"      -
   5        $��comboBox��5"      $��1��6}   $
��Left=�6�   $��	296,0,0,0q�6�   $	��Top=�6�   $	��327��6�   $��25��6�   .@�5#      �� $&�� Lista zawodników danej drużyny��6   6J   �� 5$      $'��!Średni wiek zawodników drużyny��6   6J   �� 5%      $8��2Lista rankingów aktywnych zawodników ekstraklasy��6   6\   �� 5&      $-��'Lista skutecznych bramkarzy ekstraklasy��6   6S   �� 5'      $4��.Aktualny ranking króla strzelców ekstraklasy��6   6X   �� 5(      $��Listy przyszłych kolejek��6   6D   �� 5)      $0��*Lista wyników dowolnej rozegranej kolejki��6   6U   �� 5*      $��Aktualny ranking drużyn��6   6C   �� 5+      $ ��Lista brutalnych piłkarzy��6   6E   �� 5,      $/��)Raport meczy prowadzonych przez sędziego��6   6T   5-      �� 5.      -   5         ��Name$ textBox��5.      $��1��6'   $
��Left=�67   $��25��6R   $��	628,0,0,0q�6^    �� TextWrapping$
 Wrap=�6q   $��0��6�   $��Bottom=�6�   $��36��6�   �� 5/      -   5        	 ��Name$	 label��5/      $�� ��6#   $��1��6.   $
��Left=�6>   $��	565,0,0,0q�6Y   $	��Top=�6l   51      �� 52   
   -   5        $ DeleteButton��52      $��Usuń��6B   $��0,308,401,0q�6Q   53      54      
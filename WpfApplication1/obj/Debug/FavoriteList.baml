   M S B A M L   `   `   `  ����  WpfApplication1"    WpfApplication1.FavoriteList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Favorite List��5   	   $	��434��6   $	��365��6,   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FFEEEEEE��6    � Offset$ 1Q�61   � 5	      $ 	#FFE43939��6   $ 0.167Q�61   � 5
      $ 	#FFFFD800��6   $	 0.5Q�61   5      .+�5   
   �� -   5        $��50,347,202,12q�5      $��Add Company��6(      buttonStyle#��[  6>   $
��Auto��6~   $
��Auto��6�   5      �� 5   
   -   5        $��205,349,37,12q�5      #��[  6)   $��Delete Company��6N   $
��Auto��6�   $
��Auto��6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ FavoriteList1��5         AutoGenerateColumns .  $��0,0,0,83q�6F      
IsReadOnly . $	 �� IsSynchronizedWithCurrentItem$
	 TrueY�6j   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      FontSize$ 12Q�6/      Header$ Symbol��6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� *symbol+  5      $	 120 6%   $ Company Name��61   $ 12Q�6G    6V   �� *company_name+  5      $ * 6%   $ Price��6/   $ 12Q�6>    6M   �� *price+5      5      5      
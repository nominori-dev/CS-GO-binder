   M S B A M L   `   `   `  ����E  AcsgoBinder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:csgoBinder.ViewModelscsgoBinder.ViewModels  5   	   'clr-namespace:csgoBinder
csgoBinder  5	   	       csgoBinder.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4
viewmodels#clr-namespace:csgoBinder.ViewModels  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   $localclr-namespace:csgoBinder  5	   	   -   5          � Title$  CSGO Binder��5   	    � AllowsTransparency . $��598.21��6T   $��840.113��6d    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�   ��6t   Z� ��6�   Z�  � DataContext 5      /  )csgoBinder.ViewModels.MainWindowViewModel  5   
   -   5        VMMainWindow��5   A    � 	Resources 5         	viewModel��%   &	          5   
   6)   5      .��5      � .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $��578.21��6@   $��	10,10,0,0q�6P   $	��Top=�6c   $��820.113��6{    �� RadiusY$	 3.5��6�    �� RadiusX$	 3.5��6�   �� 5   
   ���	#FF5858E8$
��Left=�6%   $��35.833��6@   $��786.613,10,0,0q�6P   $ 3.387��6h   $ 3.387��6x   $	��Top=�6�   $
��43.5��6�   �� 5   
   $��Clear��6   $
��Left=�6A   $��282,472.5,0,0q�6\   $	��Top=�6s   $��109.5��6�   $��53��6�   ��6!   �� *clearConfig+6�   �� 5   
   $��
Add action��6   $
��Left=�6E   $��282,201.703,0,0q�6`   $	��Top=�6y   $��109.5��6�   $��32��6�    J� RenderTransformOrigin$ 
0.484,0.66&�6�   ��6'   �� *	addAction+6�   �� 5   
   $
��Save��6   $
��Left=�6<   $��282,263.703,0,0q�6W   $	��Top=�6p   $��109.5��6�   $��34��6�   ��6    �� *	saveCfg+6�   �� 5   
   $��Add command��6   $
��Left=�6F   $��63.333,291,0,0q�6a   $	��Top=�6y   $	��129��6�   $��35��6�   ��6'   �� *
addCommand+6�   �� 5   
   $
��Left=�6   
���   �	 �� DisplayMemberPath$
	 Name��6�   $��43.5,223.5,0,0q�6�   $	��Top=�6�   $	��171��6�   $��35.46��6�   ��6.   �� *
Commands+
 �� SelectedItem
 6O   �� *	SCommands+6�   �� 5   
   $
��Left=�6   
���   �$
	 Name��6�   $��43.5,145.5,0,0q�6�   $	��Top=�6�   $	��171��6�   $��35.46��6�   ��6.   �� *	Actions+
 6N   �� *
SActions+6�   �� 5   
   $
��Left=�6   
���   �$
	 Name��6�   $��247.5,145.5,0,0q�6�   $	��Top=�6�   $	��171��6�   $��35.46��6�   ��6.   �� *	Buttons+
 6N   �� *
SButtons+6�   �� 5   
   $
��Left=�6   $��435.5��6-   $��442.5,90,0,0q�6<    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��357��6�   ��6R   �� *config+.��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �   �63    �� Triggers 5       P� 5!       P� Property �@J�IsMouseOver P� Value . . �5"      ��  � �� �	#FF5858E86;   �� 5#       � ��
 �����6;   �� 5$       �@J�Opacity$	 0.5Q�68   5%      5'      .��5(      5)      �� 5*   
   $
��Left=�6   $��43.5,22.833,0,0q�6/   $
��Wrap=�6H   $	��Top=�6\   
���   �$��CS:GO Binder��6�   $��31��6�   $��141.833��6�   $��22(�6�   $
��Bold"�6�   �� 5+   
   -   5         � ToolTip$ Закрыть окно��5+        MaterialDesignFlatButton#���  6(   $
��Left=�6p   $��786.613,10,0,0q�6�   $	��Top=�6�   $
��43.5��6�   $��35.833��6�   .��5,      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CloseBox=�6&   $��22.666��66   $��12.667��6F   5-      �� 5.   
   $
��Left=�6   $��43.5,556.833,0,0q�6/   $
��Wrap=�6I   $	��Top=�6]   
���   �$��Version: 0.5��6�   $��21��6�   $��79.833��6�   $
��Bold"�6�   �� 5/   
   $
��Left=�6   $��43.5,119.5,0,0q�6/   $
��Wrap=�6G   $	��Top=�6[   
���   �$��Action��6�   $��21��6�   $��41.166��6�   $
��Bold"�6�   �� 50   
   $
��Left=�6   $��43.5,197.5,0,0q�6/   $
��Wrap=�6G   $	��Top=�6[   
���   �$��Command��6�   $��21��6�   $��61.833��6�   $
��Bold"�6�   �� 51   
   $
��Left=�6   $��247.5,119.5,0,0q�6/   $
��Wrap=�6H   $	��Top=�6\   
���   �$��Button��6�   $��21��6�   $��41.166��6�   $
��Bold"�6�   �� 52   
   $
��Left=�6   $��442.5,64,0,0q�6/   $
��Wrap=�6E   $	��Top=�6Y   
���   �$��Output��6�   $��21��6�   $��41.166��6�   $
��Bold"�6�   53      54      
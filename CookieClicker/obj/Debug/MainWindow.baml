   M S B A M L   `   `   `  ����H  DCookieClicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CookieClickerCookieClicker  5   	       CookieClicker.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CookieClicker     5   	     � Title$  The One Ring��5   	   $	��450��6   $	��800��6+   .��5	      � ��5
   
   �� 5       �� ImageSource$ /assets/Background.jpg��6    j� Stretch$ UniformToFill=�6>    � ColumnDefinitions 5   
   �� 5      -   5         �Name$ Column1��5      $��1* �6.   �� 5      -   5        $ Column2��5      $��1* �6.   �� 5      -   5        $ Column3��5      $��1* �6.   .+�5   
   �� $��0��6   6'   �� 5   
   -   5        $��SauronCounterLabel��5      $�� ��6*   $��Center=�65   $��0,20,0,0q�6R   $	��Top=�6d   
���<��$��	ExtraBold"�6�   �� 5   
   -   5        $��SauronImage��5      $��/assets/Sauron.png��6#   $��Uniform=�5   	   $��Center=�5   	   $	��Top=�5   	   $��	0,120,0,0q�6!   6j   �� 5   
   $��1��6   6'   �� 5   
   $��2��6   .+�5      �� -   5        $��
ringButton��5      $��5,0,5,0q�6'   {�.   J� Opacity$
 0.33Q�6c   
���<��$��	ExtraBold"�6�   6�   �� 5      -   5        $��
wargButton��5      $��5,0,5,0q�6'   {�.  $
 0.33Q�6c   
���<��$��	ExtraBold"�6�   6�   �� 5      -   5        $��	orcButton��5      $��5,0,5,0q�6&   {�.  $
 0.33Q�6a   
���<��$��	ExtraBold"�6�   6�   �� 5      -	   5        $��urukhaiButton��5      $��5,0,5,0q�6*   {�.  $
 0.33Q�6i   
���<��$��	ExtraBold"�6�   6�   �� 5      -
   5        $��trollButton��5      $��5,0,5,0q�6(   {�.  $
 0.33Q�6e   
���<��$��	ExtraBold"�6�   6�   �� 5      -   5        $��mumakilButton��5      $��5,0,5,0q�6*   {�.  $
 0.33Q�6i   
���<��$��	ExtraBold"�6�   6�   �� 5       -   5        $��balrogButton��5       $��5,0,5,0q�6)   {�.  $
 0.33Q�6g   
���<��$��	ExtraBold"�6�   6�   �� 5!      -   5        $��nazgulButton��5!      $��5,0,5,0q�6)   {�.  $
 0.33Q�6g   
���<��$��	ExtraBold"�6�   6�   �� 5"      -   5        $��witchkingButton��5"      $��5,0,5,0q�6,   {�.  $
 0.33Q�6m   
���<��$��	ExtraBold"�6�   6�   �� 5#      -   5        $��sarumanButton��5#      $��5,0,5,0q�6*   {�.  $
 0.33Q�6i   
���<��$��	ExtraBold"�6�   6�   �� 5$      -   5        $��sauronButton��5$      $��5,0,5,0q�6)   {�.  $
 0.33Q�6g   
���<��$��	ExtraBold"�6�   6�   5%      5&      5'      
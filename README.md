# How to restrict the min, max labels overlapping on the rim in SfCircularGauge in WPF

This article explains how to add the annotations in a specific area in the Syncfusion WPF SfCircularGauge as shown in the following image.

 ![](Output.png)

This can be achieved by adding the annotations on the SfCircularGauge  with the ViewMargin property along with follow the below steps:

Step 1: Initialize the SfCircularGauge control with adding the needed range and pointers. 

Step 2: Add annotations on the SfCircularGauge with the ViewMargin property to customize the x and y position of the by using the pixel values.

Step 3:  Customize its appearance by adding the required properties like StartValue, EndValue of Range and LabelStroke, FontSize, FontWeight for CircularScale

[XAML]

```
<syncfusion:SfCircularGauge Width="200"   GaugeType="North">

        <syncfusion:SfCircularGauge.Annotations>
            <syncfusion:GaugeAnnotation ViewMargin="-50,75" >
                <TextBlock Text="0cm" FontSize="15" 
                               Foreground="Red" FontWeight="Bold"
                               HorizontalAlignment="Center" VerticalAlignment="Center"/>
            </syncfusion:GaugeAnnotation>

            <syncfusion:GaugeAnnotation ViewMargin="50,75" >
                <TextBlock Text="50cm" FontSize="15" 
                               Foreground="Red" FontWeight="Bold"
                               HorizontalAlignment="Center" VerticalAlignment="Center"/>
            </syncfusion:GaugeAnnotation>

        </syncfusion:SfCircularGauge.Annotations>
        
        <syncfusion:SfCircularGauge.Scales>

            <syncfusion:CircularScale LabelStroke="Red"                                       
                                      ShowLabels="False" 
                                      FontSize="15"
                                      FontWeight="Bold"
                                      StartValue="0" 
                                      EndValue="50" 
                                      TickStroke="Transparent"                                     
                                      Interval="50" >
                <syncfusion:CircularScale.Ranges>
                    <syncfusion:CircularRange  StartValue="0"  Stroke="LightSeaGreen" Offset = "0.3" 
                                                 StrokeThickness="20" EndValue="50"   StartWidth="0" EndWidth="50"/>
                </syncfusion:CircularScale.Ranges>
                <syncfusion:CircularScale.Pointers>
                    <syncfusion:CircularPointer 
                                                    PointerType="NeedlePointer" 
                                                    NeedlePointerType="Tapered"
                                                    NeedlePointerStroke="Black"
                                                    PointerCapStroke="Black"
                                                    NeedlePointerVisibility="Visible" 
                                                    NeedleLengthFactor="0.85"
                                                    Value="10"
                                                    EnableAnimation="True"                                                    
                                                    />
                </syncfusion:CircularScale.Pointers>
            </syncfusion:CircularScale>
        </syncfusion:SfCircularGauge.Scales>
    </syncfusion:SfCircularGauge>
```

## See also

[How do I set the start and end values for the scale](https://help.syncfusion.com/wpf/radial-gauge/scales#setting-start-and-end-values-for-scale)
 
[How do I customize the position of rim](https://help.syncfusion.com/wpf/radial-gauge/rim#setting-a-position-for-rim)
 
[How do I add a needle pointer to the gauge](https://help.syncfusion.com/wpf/radial-gauge/pointers#needle-pointer)
 
[How to change the position of ticks](https://help.syncfusion.com/wpf/radial-gauge/ticks#setting-ticks-visibility-in-scale)



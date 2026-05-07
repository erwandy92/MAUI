    <ContentPage.Resources>
        <x:String x:Key="SubTitle">System Info.</x:String>
        <x:Double x:Key="H1">32</x:Double>
        <x:Double x:Key="Normal">20</x:Double>
        <Color x:Key="ForeColor">DarkBlue</Color>
        <Color x:Key="BackColor">LightBlue</Color>
    </ContentPage.Resources>



    <ContentPage.Resources>
        <x:String x:Key="SubTitle">System Info.</x:String>
        <x:Double x:Key="H1">32</x:Double>
        <x:Double x:Key="Normal">20</x:Double>
        <Color x:Key="ForeColor">DarkBlue</Color>
        <Color x:Key="BackColor">LightBlue</Color>
        <Style TargetType="Label">
            <Setter Property="TextColor" Value="{StaticResource ForeColor}"></Setter>
            <Setter Property="FontSize" Value="{StaticResource Normal}"></Setter>
        </Style>
        <Style x:Key="Header" TargetType="Label">
            <Setter Property="Background" Value="{StaticResource BackColor}"></Setter>
            <Setter Property="TextColor" Value="{StaticResource ForeColor}"></Setter>
            <Setter Property="FontSize" Value="{StaticResource H1}"></Setter>
        </Style>
    </ContentPage.Resources>



        <Label  Text="Welcome to .NET MAUI!" BackgroundColor="Red" />
        <Label  Text="Welcome to .NET MAUI!" BackgroundColor="Orange"/>
        <Label  Text="Welcome to .NET MAUI!" BackgroundColor="Yellow" />
        <Label  Text="Welcome to .NET MAUI!" BackgroundColor="Green" />
        <Label  Text="Welcome to .NET MAUI!" BackgroundColor="blue" />
        <Label  Text="Welcome to .NET MAUI!" BackgroundColor="Indigo" />
        <Label  Text="Welcome to .NET MAUI!" BackgroundColor="Purple" />





<MauiIcon Include="Resources\AppIcon\appicon.jpg"  BaseSize="1024,1024" ></MauiIcon>

<MauiSplashScreen Include="Resources\Splash\mysplash.jpg" BaseSize="1024,1024" Color="White" />


keytool -genkey -v -keystore key.keystore -alias MauiAlias -keyalg RSA -keysize 2048 -validity 10000

dotnet publish mod081.csproj -c Release -f:net9.0-android


Cd C:\[專案路徑]\bin\Release\net9.0-android\publish
adb install com.uuu.maui-Signed.apk
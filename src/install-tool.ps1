function Get-ScriptDirectory {
    Split-Path -parent $PSCommandPath
}

dotnet pack -c Release /p:Version=0.0.0
dotnet tool uninstall -g TrxToHtml
dotnet tool install -g --add-source "$(Get-ScriptDirectory)/TrxToHtml/bin/Release" --version 0.0.0 TrxToHtml

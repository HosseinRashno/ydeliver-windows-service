param(
    $applications = @("ydeliver-windows-service"),
    $buildNumber = "1.0.0",
    $artifactsDir = "$(pwd)\build"
    )

$script:scriptDir = split-path $MyInvocation.MyCommand.Path -parent

#Import-Module $script:scriptDir\BuildScripts\YDeliver.psm1
Invoke-YInstall $applications -buildVersion $buildNumber

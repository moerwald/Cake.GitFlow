function Run-Cake {
    [CmdletBinding( ConfirmImpact='Medium')]
    Param (
    )
    
    
    end {
        & $PSScriptRoot/build/build.ps1 -Script $PSScriptRoot/build/build.cake
    }
}


Run-Cake

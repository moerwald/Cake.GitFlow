Describe 'Create release without a release branch and create a GIT tag'{
    $tempFolder = [System.Guid]::NewGuid()
    $origLocation = Get-Location
    $scriptRoot = $PSScriptRoot
    BeforeEach {
        Push-Location

        #Create temp folder
        New-Item -ItemType Directory -Path $env:Temp -Name $tempFolder
        Set-Location -Path (Join-Path -Path $env:Temp -ChildPath $tempFolder)

        # Prepare test GIT repository
        & git init
        $readMe = "ReadMe.md"
        New-Item -ItemType File -Name $readMe
        & git add $readMe
        & git commit -m 'Initial commit'
        & git checkout -b 'develop'
        "test" >> $readMe
        & git commit -a -m '1st change'
    }

    AfterEach {
        Pop-Location
        Remove-Item -Path (Join-Path -Path $env:Temp -ChildPath $tempFolder) -Recurse -Force
    }

    It "Merge develop directly to master branch and create a GIT tag"{
        & "$scriptRoot/build.ps1" -Script "$scriptRoot/build.cake" -ScripArgs '-newGitTagVersion="1.0.0"'
    }
}
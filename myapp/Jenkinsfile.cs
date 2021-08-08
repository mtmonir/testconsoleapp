﻿pipeline
{
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building..'
                dotnetBuild myapp/myapp.csproj
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
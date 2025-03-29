pipeline {
    agent any

    stages {
        stage('Git Checkout') {
            steps {
                git credentialsId: '8d1e63f1-cb7b-4a1d-89eb-3795cd79c6b5', branch: 'master', url: 'https://github.com/hpacome/ambre.git'
            }
        }

        stage('Build') {
            steps {
                script {
                    echo 'Start build stage'
                    sh 'dotnet build'
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    echo 'Start test stage'
                    sh 'dotnet test'
                }
            }
        }
    }
}

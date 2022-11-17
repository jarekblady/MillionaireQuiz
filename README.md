# Who wants to be a Millionaire

## How To Run

#### 1. In the first step, change "ConnectionStrings" in [appsettings.Development.json](https://github.com/jarekblady/MillionaireQuiz/blob/master/MillionaireQuiz/appsettings.Development.json)
#### 2. In Package Manager Console run `update-database` command
#### 3. To generate data for a database, use a script with data [GenerateData.sql](https://github.com/jarekblady/MillionaireQuiz/blob/master/GenerateData.sql)

## Database
#### Tables in Database
#### 1. [Questions](https://github.com/jarekblady/MillionaireQuiz/blob/master/MillionaireQuiz/Entities/Question.cs)
#### 2. [Answers](https://github.com/jarekblady/MillionaireQuiz/blob/master/MillionaireQuiz/Entities/Answer.cs) 
####    Entity Framework Core- data access technology. The project uses a development approach: Code-First.

## Architecture
#### -[Repositories](https://github.com/jarekblady/MillionaireQuiz/tree/master/MillionaireQuiz/Repositories) is layer between the rest of the application and the data access logic.
#### -[Models](https://github.com/jarekblady/MillionaireQuiz/tree/master/MillionaireQuiz/Models)
####  [QuestionViewModel](https://github.com/jarekblady/MillionaireQuiz/blob/master/MillionaireQuiz/Models/QuestionViewModel.cs) is a model containing data from database.
#### -[Services](https://github.com/jarekblady/MillionaireQuiz/tree/master/MillionaireQuiz/Services)
####  [QuizService](https://github.com/jarekblady/MillionaireQuiz/blob/master/MillionaireQuiz/Services/QuizService.cs) is layer between the controller and the model to transfer business logic from the controller.
#### -[Controllers](https://github.com/jarekblady/MillionaireQuiz/tree/master/MillionaireQuiz/Controllers)
####  [QuizController](https://github.com/jarekblady/MillionaireQuiz/blob/master/MillionaireQuiz/Controllers/QuizController.cs) handles user request and returns the appropriate view.

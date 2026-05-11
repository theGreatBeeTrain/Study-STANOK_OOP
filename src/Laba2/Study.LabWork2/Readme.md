<a name='assembly'></a>
# Study.LabWork2

## Contents

- [AsynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp')
  - [ExecuteRequestsAsync\`\`1()](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.ExecuteRequestsAsync``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
- [IRunService](#T-Study-LabWork2-Shared-Abstractions-IRunService 'Study.LabWork2.Shared.Abstractions.IRunService')
  - [RunTask1()](#M-Study-LabWork2-Shared-Abstractions-IRunService-RunTask1 'Study.LabWork2.Shared.Abstractions.IRunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork2-Shared-Abstractions-IRunService-RunTask2 'Study.LabWork2.Shared.Abstractions.IRunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork2-Shared-Abstractions-IRunService-RunTask3 'Study.LabWork2.Shared.Abstractions.IRunService.RunTask3')
- [MonitorService](#T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService')
- [MutexService](#T-Study-LabWork2-Feature-Task1-SubTask1-MutexService 'Study.LabWork2.Feature.Task1.SubTask1.MutexService')
- [NumberSetProcessor](#T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor')
- [RunService](#T-Study-LabWork2-Shared-Services-RunService 'Study.LabWork2.Shared.Services.RunService')
  - [RunTask1()](#M-Study-LabWork2-Shared-Services-RunService-RunTask1 'Study.LabWork2.Shared.Services.RunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork2-Shared-Services-RunService-RunTask2 'Study.LabWork2.Shared.Services.RunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork2-Shared-Services-RunService-RunTask3 'Study.LabWork2.Shared.Services.RunService.RunTask3')
- [SemaphoreService](#T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService')
- [SynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp')

<a name='T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp'></a>
## AsynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Асинхронная версия приложения (с использованием async/await)

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequestsAsync\`\`1() `method`

##### Summary

Асинхронное выполнение запросов

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Shared-Abstractions-IRunService'></a>
## IRunService `type`

##### Namespace

Study.LabWork2.Shared.Abstractions

##### Summary

Интерфейс для реализации заданий Л/Р

<a name='M-Study-LabWork2-Shared-Abstractions-IRunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Запуск выполнения задания 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Shared-Abstractions-IRunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Запуск выполнения задания 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Shared-Abstractions-IRunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Запуск выполнения задания 3

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService'></a>
## MonitorService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 1. Использует Monitor (lock) для синхронизации

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MutexService'></a>
## MutexService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 2. Использует Mutex для синхронизации

<a name='T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor'></a>
## NumberSetProcessor `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask2

##### Summary

Определяет реализацию для процессора наборов чисел

<a name='T-Study-LabWork2-Shared-Services-RunService'></a>
## RunService `type`

##### Namespace

Study.LabWork2.Shared.Services

##### Summary

Реализация заданий Л/Р

<a name='M-Study-LabWork2-Shared-Services-RunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Задание 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Shared-Services-RunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Задание 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Shared-Services-RunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Задание 3

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService'></a>
## SemaphoreService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 3. Использует Semaphore для синхронизации

<a name='T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp'></a>
## SynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Синхронная версия приложения (без использования async/await)

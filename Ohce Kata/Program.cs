﻿using Ohce_Kata.Services;

var ohceKataService = new OhceKataService();
var runnerService = new RunnerService(ohceKataService);
runnerService.Run();
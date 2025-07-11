﻿using AbstractFactory.Logger.Abstraction;
using AbstractFactory.Logger.Abstraction.Enums;
using AbstractFactory.Logger.Formating;
using AbstractFactory.Logger.Outputs;

namespace AbstractFactory.Logger.Factories;

public static class LoggerFactory
{
    public static ILogger CreateLogger(Output output, Format format)
    {
        IFormatter formatter;
        IOutput outputter;
        
        switch (format)
        {
            case Format.Text:
            {
                formatter = new TextFormatter();
                break;
            }
            case Format.Json:
            {
                formatter = new JsonFormatter();
                break;
            }
            default:
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        
        switch (output)
        {
            case Output.Console:
            {
                outputter = new ConsoleOutput();
                break;
            }
            case Output.File:
            {
                outputter = new FileOutput("log.txt");
                break;
            }
            default:
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        return new AbstractFactory.Logger.Factories.Logger(formatter, outputter);
    }
}
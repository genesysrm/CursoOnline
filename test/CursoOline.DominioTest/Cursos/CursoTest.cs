using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoOline.DominioTest.Cursos
{
    public class CursoTest
    {
        [Fact]
        public void DeveCriarDominio() 
        {

            var cursoEsperado = new
            {
                Nome = "Informatica Básica",
                CargaHoraria = 80,
                PublicoAlvo = "Estudantes",
                Valor = 950


            };
         

            //açaõ
            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

            //Assert

            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
           
        }
    }

    public class Curso
    {
        public Curso(string nome, double cargaHoraria, string publicoAlvo, double valor)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }

        public string Nome { get; set; }
        public double CargaHoraria { get; set; }
        public string PublicoAlvo { get; set; }
        public double Valor { get; set; }
    }

}


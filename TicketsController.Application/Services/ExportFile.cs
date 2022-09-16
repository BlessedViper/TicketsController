using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using TicketsController.Domain.Entities;

namespace TicketsController.Application.Services
{
    public class ExportFile
    {
        private ExcelPackage _package;
        private string _folder;
        public ExportFile()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            _package = new();
        }

        public void ExportAnaliseDemanda(string caminho, List<Ticket> tickets, IProgress<int> progress)
        {
            
            _folder = caminho;
            var worksheet = _package.Workbook.Worksheets.Add("Tickets");

            var indice = 2;
            var progressFor = 0;
            var listCount = tickets.Count;

            worksheet.Cells[1, 1].Value = "Ticket";
            worksheet.Cells[1, 2].Value = "Titulo";
            worksheet.Cells[1, 3].Value = "Categoria";
            worksheet.Cells[1, 4].Value = "Serviço Nv1";
            worksheet.Cells[1, 5].Value = "Serviço NV2";
            worksheet.Cells[1, 6].Value = "Serviço Nv3";
            worksheet.Cells[1, 7].Value = "Serviço Nv4";
            worksheet.Cells[1, 8].Value = "Serviço Nv5";

            foreach (var ticket in tickets)
            {
                worksheet.Cells[indice, 1].Value = ticket.Id;
                worksheet.Cells[indice, 2].Value = ticket.Titulo;
                worksheet.Cells[indice, 3].Value = ticket.Categoria;
                worksheet.Cells[indice, 4].Value = ticket.Service.Service1;
                worksheet.Cells[indice, 5].Value = ticket.Service.Service2;
                worksheet.Cells[indice, 6].Value = ticket.Service.Service3;
                worksheet.Cells[indice, 7].Value = ticket.Service.Service4;
                worksheet.Cells[indice, 8].Value = ticket.Service.Service5;
                indice++;
                progressFor++;

                var progressComplete = (progressFor * 100) / listCount;
                progress.Report(progressComplete);
            }

            worksheet.Column(1).AutoFit();
            worksheet.Column(2).AutoFit();
            worksheet.Column(3).AutoFit();
            worksheet.Column(4).AutoFit();
            worksheet.Column(5).AutoFit();
            worksheet.Column(6).AutoFit();
            worksheet.Column(7).AutoFit();
            worksheet.Column(8).AutoFit();

            if (File.Exists(_folder))
                File.Delete(_folder);

            FileStream file = File.Create(_folder);
            file.Close();

            File.WriteAllBytes(_folder, _package.GetAsByteArray());

            _package.Dispose();
        }

        public void ExportAll(string caminho, List<Ticket> tickets, IProgress<int> progress)
        {
            _folder = caminho;

            var worksheet = _package.Workbook.Worksheets.Add("Tickets");

            var indice = 2;
            var progressFor = 0;
            var listCount = tickets.Count;

            // Inserção do título das tabelas
            worksheet.Cells[1, 1].Value = "Ticket";
            worksheet.Cells[1, 2].Value = "Titulo";
            worksheet.Cells[1, 3].Value = "Categoria";
            worksheet.Cells[1, 4].Value = "Status";
            worksheet.Cells[1, 5].Value = "Data Criação";
            worksheet.Cells[1, 6].Value = "Ultima ação";
            worksheet.Cells[1, 7].Value = "Serviço Nv1";
            worksheet.Cells[1, 8].Value = "Serviço NV2";
            worksheet.Cells[1, 9].Value = "Serviço Nv3";
            worksheet.Cells[1, 10].Value = "Serviço Nv4";
            worksheet.Cells[1, 11].Value = "Serviço Nv5";

            // Inserção de dados na planilha
            foreach (var ticket in tickets)
            {
                var dataCriacao = ticket.DataCriacao.ToString("dd/MM/yyyy");
                var ultimaAcao = ticket.UltimaAcao.ToString("dd/MM/yyyy");
                worksheet.Cells[indice, 1].Value = ticket.Id;
                worksheet.Cells[indice, 2].Value = ticket.Titulo;
                worksheet.Cells[indice, 3].Value = ticket.Categoria;
                worksheet.Cells[indice, 4].Value = ticket.Status;
                worksheet.Cells[indice, 5].Value = dataCriacao;
                worksheet.Cells[indice, 6].Value = ultimaAcao;
                worksheet.Cells[indice, 7].Value = ticket.Service.Service1;
                worksheet.Cells[indice, 8].Value = ticket.Service.Service2;
                worksheet.Cells[indice, 9].Value = ticket.Service.Service3;
                worksheet.Cells[indice, 10].Value = ticket.Service.Service4;
                worksheet.Cells[indice, 11].Value = ticket.Service.Service5;

                indice++;
                progressFor++;

                var progressComplete = (progressFor * 100) / listCount;
                progress.Report(progressComplete);
            }
            // Formatação da Coluna
            worksheet.Column(1).AutoFit();
            worksheet.Column(2).AutoFit();
            worksheet.Column(3).AutoFit();
            worksheet.Column(4).AutoFit();
            worksheet.Column(5).AutoFit();
            worksheet.Column(6).AutoFit();
            worksheet.Column(7).AutoFit();
            worksheet.Column(8).AutoFit();
            worksheet.Column(9).AutoFit();
            worksheet.Column(10).AutoFit();
            worksheet.Column(11).AutoFit();

            if (File.Exists(_folder))
                File.Delete(_folder);

            // cria o arquivo no caminho informado
            FileStream file = File.Create(_folder);
            file.Close();

            // insere os dados no excel
            File.WriteAllBytes(_folder, _package.GetAsByteArray());

            // fecha o arquivo excel
            _package.Dispose();
        }
    }
}

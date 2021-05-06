using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ProjetoCare.Utils.ArchiveUpload
{
    public class UploadFile
    {
        private readonly IWebHostEnvironment _environment;
        public UploadFile(IWebHostEnvironment _environment)
        {
            this._environment = _environment;
        }

        /// <summary>
        /// Hospedagem de imagem para a pasta local com validação
        /// </summary>
        /// <param name="image">Arquivo de imagem</param>
        /// <returns>Retorna o nome da imagem gerado pelo sistema</returns>
        public async Task<string> UploadFileToLocal(IFormFile image)
        {       
            if(image == null || Validations.Validations.DefaultSingleStringValidation(image.ToString(), 500).Equals(false) || Validations.Validations.IsImage(image).Equals(false))
            return null;

            try
            {
                //Nome da imagem
                string archive = "_Produto_" + Guid.NewGuid() + ".png";

                using (FileStream stream = new FileStream(Path.Combine(Path.Combine(_environment.WebRootPath, "pdts"), archive), FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                return archive;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Exclusao de arquivo fisico local
        /// </summary>
        /// <param name="filename">nome do arquivo fisico</param>
        /// <returns>exclui o arquivo solicitado</returns>
        public async Task DeleteLocalFile(string filename)
		{
			try
			{
                await Task.Delay(1000);
                var pasta = Path.Combine(_environment.WebRootPath, "pdts");
                File.Delete(pasta + "/" + filename);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

    }
}
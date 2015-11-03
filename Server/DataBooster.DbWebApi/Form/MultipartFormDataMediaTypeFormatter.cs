﻿using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DataBooster.DbWebApi.Form
{
	/// <summary>
	/// <see cref="MediaTypeFormatter"/> class for handling HTML Form Data - File Upload and Multipart MIME, also known as <c>multipart/form-data</c>. 
	/// </summary>
	public class MultipartFormDataMediaTypeFormatter : MediaTypeFormatter
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MultipartFormDataMediaTypeFormatter"/> class.
		/// </summary>
		public MultipartFormDataMediaTypeFormatter()
		{
			SupportedMediaTypes.Add(DefaultMediaType);
		}

		public static MediaTypeHeaderValue DefaultMediaType
		{
			get { return MediaTypeConstants.MultipartFormDataMediaType; }
		}

		public override bool CanReadType(Type type)
		{
			return type == typeof(InputParameters);
		}

		public override bool CanWriteType(Type type)
		{
			return false;
		}

		/// <param name="type">The type of the object to deserialize.</param>
		/// <param name="readStream">The <see cref="T:System.IO.Stream"/> to read.</param>
		/// <param name="content">The <see cref="T:System.Net.Http.HttpContent"/>, if available. It may be null.</param>
		/// <param name="formatterLogger">The <see cref="T:System.Net.Http.Formatting.IFormatterLogger"/> to log events to.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task"/> whose result will be an object of the given type.</returns>
		public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}

			if (readStream == null)
			{
				throw new ArgumentNullException("readStream");
			}

			// TODO
			return null;
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TitanInformationSolutions.Models
{
	public class Sub
	{
		public int ID { get; set; }

		[StringLength(127)]
		public string Name { get; set; }

		[StringLength(512)]
		public string PushEndpoint { get; set; }

		[StringLength(512)]
		public string PushP256DH { get; set; }

		[StringLength(512)]
		public string PushAuth { get; set; }

		public int ParentID { get; set; }
		public Parent Parent { get; set; }
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace Restore_Resx_Files_from_localizable
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SelectSourceBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(SourcePathEdit.Text))
			{
				openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(SourcePathEdit.Text);
			}

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				SourcePathEdit.Text = openFileDialog1.FileName;

				if (!string.IsNullOrEmpty(openFileDialog1.FileName) && openFileDialog1.FileName.Contains(".ru"))
				{
					DestPathEdit.Text = openFileDialog1.FileName.Replace(".ru", string.Empty);
				}
			}
		}

		private void SelectDestBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(DestPathEdit.Text))
			{
				saveFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(DestPathEdit.Text);
			}

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				DestPathEdit.Text = saveFileDialog1.FileName;
			}
		}

		IDictionary<string, object> destValues = new Dictionary<string, object>();
		IDictionary<string, object> destMetaValues = new Dictionary<string, object>();
		IDictionary<string, object> sourceValues = new Dictionary<string, object>();

		private void RunBtn_Click(object sender, EventArgs e)
		{
			var lst = new List<long>();

			ResultBox.Text = string.Empty;

			destValues.Clear();
			sourceValues.Clear();
			destMetaValues.Clear();

			var modules = AppDomain.CurrentDomain.GetAssemblies().Select(m => m.GetName()).ToArray();

			using (ResXResourceReader resxReader = new ResXResourceReader(DestPathEdit.Text, modules))
			{
				foreach (DictionaryEntry entry in resxReader)
				{
					destValues.Add((string)entry.Key, entry.Value);
				}

				IDictionaryEnumerator metadataEnumerator = resxReader.GetMetadataEnumerator();

				while (metadataEnumerator.MoveNext())
				{
					destMetaValues.Add((string)metadataEnumerator.Entry.Key, metadataEnumerator.Entry.Value);
				}

			}


			using (ResXResourceReader resxReader = new ResXResourceReader(SourcePathEdit.Text, modules))
			{
				foreach (DictionaryEntry entry in resxReader)
				{
					sourceValues.Add((string)entry.Key, entry.Value);
				}
			}

			var countNew = 0;
			var countReplaced = 0;
			var countUnchanged = 0;

			using (ResXResourceWriter resx = new ResXResourceWriter(DestPathEdit.Text))
			{
				foreach (var a in destValues)
				{
					var value = a.Value;

					var forceUseDest = (a.Key.EndsWith(".Text") || a.Key.EndsWith(".Caption")) && a.Value != null && !string.IsNullOrWhiteSpace(a.Value.ToString());

					if (!forceUseDest && sourceValues.ContainsKey(a.Key))
					{
						resx.AddResource(a.Key, sourceValues[a.Key]);
						countReplaced += 1;
					}
					else
					{
						resx.AddResource(a.Key, a.Value);
						countUnchanged += 1;
					}
				}

				foreach (var a in destMetaValues)
				{
					resx.AddMetadata(a.Key, a.Value);
				}


				foreach (var a in sourceValues)
				{
					if (!destValues.ContainsKey(a.Key))
					{
						if ((a.Key.EndsWith(".Text") || a.Key.EndsWith(".Caption")) && a.Value != null && !string.IsNullOrWhiteSpace(a.Value.ToString()))
						{
							resx.AddResource(a.Key, "_" + a.Value.ToString());
						}
						else
						{
							resx.AddResource(a.Key, a.Value);
						}

						countNew++;
					}
				}
				resx.Generate();

				ResultBox.Text += string.Format("Count new added elements from source resx file = {0}{1}", countNew, Environment.NewLine);
				ResultBox.Text += string.Format("Count replaced elements from source resx file = {0}{1}", countReplaced, Environment.NewLine);
				ResultBox.Text += string.Format("Count unchanged elements in dest resx file = {0}{1}", countUnchanged, Environment.NewLine);
			}
		}
	}
}

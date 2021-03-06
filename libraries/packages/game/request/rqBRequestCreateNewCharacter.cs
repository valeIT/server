﻿using System;
using System.IO;
using System.Text;

using Libraries.enums;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestCreateNewCharacter.
    /// </summary>
    public class PacketBRequestCreateNewCharacter
    {

        public int SkipTutorial { get; }

        public long Xuid { get; }

        public Civilizations CivilizationId { get; }

        public string CityName { get; }
        public string CityScenario { get; }

        public PacketBRequestCreateNewCharacter(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();

                    int CityNameLength = Reader.ReadInt32();

                    CityName = Encoding.Unicode.GetString(Reader.ReadBytes(CityNameLength));

                    int CityScenarioLength = Reader.ReadInt32();

                    CityScenario = Encoding.Unicode.GetString(Reader.ReadBytes(CityScenarioLength));
                    CivilizationId = (Civilizations)Reader.ReadInt32();

                    SkipTutorial = Convert.ToInt32(Reader.ReadByte());

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestCreateNewCharacter\r\n" +
               "Xuid = 0x{0:X}\r\n" +
               "CityName = {1}\r\n" +
               "CityScenario = {2}\r\n" +
               "Civilization = {3}\r\n" +
               "SkipTutorial = {4}\r\n",
               Xuid,
               CityName,
               CityScenario,
               CivilizationId,
               SkipTutorial
           );

        }

    }

}

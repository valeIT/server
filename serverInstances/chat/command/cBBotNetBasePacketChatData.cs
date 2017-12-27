﻿using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.chat;

using Libraries.enums;
using Libraries.player;


namespace Chat.command
{

    public class BBotNetBasePacketChatData : CommandBase<Session, PackageChat>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, PackageChat p)
        {

            PacketBBotNetBasePacketChatDataRequest Request = new PacketBBotNetBasePacketChatDataRequest(p.Content);

            //@TODO - Create custom chat level to spam only when requested
            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            PacketBBotNetBasePacketChatDataResponse ResponseContent = new PacketBBotNetBasePacketChatDataResponse(Request.ChannelName, Request.PlayerName, Request.ChatMessage);

            //@TODO - Create custom chat level to spam only when requested
            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            PackageChat Package = new PackageChat(p.HeaderUnk0, p.HeaderXuid, PacketTypesChat.BBotNetBasePacketChatData, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
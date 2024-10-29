﻿namespace ClashRoyale.Listener
{
    using ClashRoyale.Logic;
    using ClashRoyale.Messages;
    using ClashRoyale.Network;

    public sealed class ServerGameListener : GameListener
    {
        private readonly Device Device;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerGameListener"/> class.
        /// </summary>
        /// <param name="Device">The device.</param>
        public ServerGameListener(Device Device)
        {
            this.Device = Device;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is connected.
        /// </summary>
        public override bool IsConnected
        {
            get
            {
                return this.Device.Token.IsConnected;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is an android device.
        /// </summary>
        public override bool IsAndroid
        {
            get
            {
                return this.Device.Defines.Android;
            }
        }

        /// <summary>
        /// Adds this instance to the matchmaking system.
        /// </summary>
        public override void Matchmaking()
        {
            // TODO Implement Matchmaking.
        }

        /// <summary>
        /// Sends the specified <see cref="Message" />.
        /// </summary>
        /// <param name="Message">The message.</param>
        public override void SendMessage(Message Message)
        {
            this.Device.NetworkManager.SendMessage(Message);
        }

        /// <summary>
        /// Disconnects this instance.
        /// </summary>
        public override void Disconnect()
        {
            NetworkTcp.Disconnect(this.Device.Token.AsyncEvent);
        }
    }
}
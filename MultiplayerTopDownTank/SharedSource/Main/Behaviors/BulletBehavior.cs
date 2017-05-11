﻿using MultiplayerTopDownTank.Entities;
using System;
using WaveEngine.Common.Math;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Physics2D;

namespace MultiplayerTopDownTank.Behaviors
{
    public class BulletBehavior : Behavior
    {
        private Bullet bullet;
        private Vector2 direction;
        private float velocity = 15f;

        [RequiredComponent]
        private Transform2D transform;

        [RequiredComponent(false)]
        private Collider2D collider;

        /// <summary>
        /// Initializes a new instance of the <see cref="BulletBehavior" /> class.
        /// </summary>
        /// <param name="bullet">The bullet.</param>
        public BulletBehavior(Bullet bullet)
        {
            this.bullet = bullet;
        }

        /// <summary>
        /// Allows this instance to execute custom logic during its <c>Update</c>.
        /// </summary>
        /// <param name="gameTime">The game time.</param>
        /// <remarks>
        /// This method will not be executed if the <see cref="T:WaveEngine.Framework.Component" />, or the <see cref="T:WaveEngine.Framework.Entity" />
        /// owning it are not <c>Active</c>.
        /// </remarks>
        protected override void Update(TimeSpan gameTime)
        {
            if (!this.Owner.IsVisible)
                return;

            this.direction = bullet.Direction;
            float fps = 60 * (float)gameTime.TotalSeconds;
            this.transform.X += this.direction.X * velocity * fps;
            this.transform.Y += this.direction.Y * velocity * fps;
        }
    }
}
using System.Collections.Generic;

namespace LibDescent.Data
{
    public interface IGameDataProvider
    {
        List<ushort> Textures { get; }
        /// <summary>
        /// List of information for mapping textures into levels.
        /// </summary>
        List<TMAPInfo> TMapInfo { get; }
        /// <summary>
        /// List of sound IDs.
        /// </summary>
        byte[] Sounds { get; }
        /// <summary>
        /// List to remap given sounds into other sounds when Descent is run in low memory mode.
        /// </summary>
        byte[] AltSounds { get; }
        /// <summary>
        /// List of all VClip animations.
        /// </summary>
        List<VClip> VClips { get; }
        /// <summary>
        /// List of all Effect animations.
        /// </summary>
        List<EClip> EClips { get; }
        /// <summary>
        /// List of all Wall (door) animations.
        /// </summary>
        List<WClip> WClips { get; }
        /// <summary>
        /// List of all robots.
        /// </summary>
        List<Robot> Robots { get; }
        /// <summary>
        /// List of all robot joints used for animation.
        /// </summary>
        List<JointPos> Joints { get; }
        /// <summary>
        /// List of all weapons.
        /// </summary>
        List<Weapon> Weapons { get; }
        /// <summary>
        /// List of all polymodels.
        /// </summary>
        List<Polymodel> Models { get; }
        /// <summary>
        /// List of gauge piggy IDs.
        /// </summary>
        List<ushort> Gauges { get; }
        /// <summary>
        /// List of gague piggy IDs used for the highres cockpit.
        /// </summary>
        List<ushort> GaugesHires { get; }
        /// <summary>
        /// List of piggy IDs available for polymodels.
        /// </summary>
        List<ushort> ObjBitmaps { get; }
        /// <summary>
        /// List of pointers into the ObjBitmaps table for polymodels.
        /// </summary>
        List<ushort> ObjBitmapPointers { get; }
        /// <summary>
        /// The player ship.
        /// </summary>
        Ship PlayerShip { get; set; }
        /// <summary>
        /// List of piggy IDs for all heads-up display modes.
        /// </summary>
        List<ushort> Cockpits { get; }
        /// <summary>
        /// List of all reactors.
        /// </summary>
        List<Reactor> Reactors { get; }
        /// <summary>
        /// List of all powerups.
        /// </summary>
        List<Powerup> Powerups { get; }
        /// <summary>
        /// The index in the ObjBitmapPointers table of the first multiplayer color texture.
        /// </summary>
        int FirstMultiBitmapNum { get; set; }
        /// <summary>
        /// Table to remap piggy IDs to other IDs for low memory mode.
        /// </summary>
        ushort[] BitmapXLATData { get; }
        //Demo specific data
        //int ExitModelnum, DestroyedExitModelnum;

        //byte[] sounddata;

        IGameDataProvider Clone();
    }
}

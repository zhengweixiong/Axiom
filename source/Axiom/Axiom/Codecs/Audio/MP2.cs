﻿/* ----------------------------------------------------------------------
Axiom UI
Copyright (C) 2017-2019 Matt McManis
http://github.com/MattMcManis/Axiom
http://axiomui.github.io
mattmcmanis@outlook.com

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.If not, see <http://www.gnu.org/licenses/>. 
---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axiom
{
    public class MP2
    {
        // ---------------------------------------------------------------------------
        // Arguments
        // ---------------------------------------------------------------------------

        // -------------------------
        // Codec
        // -------------------------
        public static string codec = "-c:a mp2";



        // ---------------------------------------------------------------------------
        // Item Source
        // ---------------------------------------------------------------------------

        // -------------------------
        // Quality
        // -------------------------
        public static List<ViewModel.AudioQuality> quality = new List<ViewModel.AudioQuality>()
        {
             new ViewModel.AudioQuality() { Name = "Auto",    CBR_BitMode = "-b:a", CBR = "",    VBR_BitMode = "-q:a", VBR = "", NA = "384" },
             new ViewModel.AudioQuality() { Name = "384",     CBR_BitMode = "-b:a", CBR = "384", VBR_BitMode = "-q:a", VBR = "0"   },
             new ViewModel.AudioQuality() { Name = "320",     CBR_BitMode = "-b:a", CBR = "320", VBR_BitMode = "-q:a", VBR = "0"   },
             new ViewModel.AudioQuality() { Name = "256",     CBR_BitMode = "-b:a", CBR = "256", VBR_BitMode = "-q:a", VBR = "0"   },
             new ViewModel.AudioQuality() { Name = "224",     CBR_BitMode = "-b:a", CBR = "224", VBR_BitMode = "-q:a", VBR = "1"   },
             new ViewModel.AudioQuality() { Name = "192",     CBR_BitMode = "-b:a", CBR = "192", VBR_BitMode = "-q:a", VBR = "2"   },
             new ViewModel.AudioQuality() { Name = "160",     CBR_BitMode = "-b:a", CBR = "160", VBR_BitMode = "-q:a", VBR = "3"   },
             new ViewModel.AudioQuality() { Name = "128",     CBR_BitMode = "-b:a", CBR = "128", VBR_BitMode = "-q:a", VBR = "5"   },
             new ViewModel.AudioQuality() { Name = "96",      CBR_BitMode = "-b:a", CBR = "96",  VBR_BitMode = "-q:a", VBR = "7"   },
             new ViewModel.AudioQuality() { Name = "Custom",  CBR_BitMode = "-b:a", CBR = "",    VBR_BitMode = "-q:a", VBR = ""    },
             new ViewModel.AudioQuality() { Name = "Mute",    CBR_BitMode = "",     CBR = "",    VBR_BitMode = "",     VBR = ""    }
        };

        // -------------------------
        // Channel
        // -------------------------
        public static List<string> channel = new List<string>()
        {
            "Source",
            "Stereo",
            "Mono",
            "5.1"
        };

        // -------------------------
        // Sample Rate
        // -------------------------
        public static List<ViewModel.AudioSampleRate> sampleRate = new List<ViewModel.AudioSampleRate>()
        {
             new ViewModel.AudioSampleRate() { Name = "auto",     Frequency = "" },
             new ViewModel.AudioSampleRate() { Name = "16k",      Frequency = "16000" },
             new ViewModel.AudioSampleRate() { Name = "22.05k",   Frequency = "22050" },
             new ViewModel.AudioSampleRate() { Name = "24k",      Frequency = "24000" },
             new ViewModel.AudioSampleRate() { Name = "32k",      Frequency = "32000" },
             new ViewModel.AudioSampleRate() { Name = "44.1k",    Frequency = "44100" },
             new ViewModel.AudioSampleRate() { Name = "48k",      Frequency = "48000" },
        };

        // -------------------------
        // Bit Depth
        // -------------------------
        public static List<ViewModel.AudioBitDepth> bitDepth = new List<ViewModel.AudioBitDepth>()
        {
             new ViewModel.AudioBitDepth() { Name = "auto", Depth = "" }
        };



        // ---------------------------------------------------------------------------
        // Controls Behavior
        // ---------------------------------------------------------------------------

        // -------------------------
        // Item Source
        // -------------------------
        public static void controlsItemSource(ViewModel vm)
        {
            // Quality
            vm.AudioQuality_Items = quality;

            // Channel
            vm.AudioChannel_Items = channel;

            // Samplerate
            vm.AudioSampleRate_Items = sampleRate;

            // Bit Depth
            vm.AudioBitDepth_Items = bitDepth;
        }

        // -------------------------
        // Selected Items
        // -------------------------
        public static void controlsSelected(ViewModel vm)
        {
            //vm.AudioStream_SelectedItem = "all";
        }

        // -------------------------
        // Checked
        // -------------------------
        public static void controlsChecked(ViewModel vm)
        {
            // None
        }

        // -------------------------
        // Unchecked
        // -------------------------
        public static void controlsUnhecked(ViewModel vm)
        {
            // Bitrate Mode
            vm.AudioVBR_IsChecked = false;
        }

        // -------------------------
        // Enabled
        // -------------------------
        public static void controlsEnable(ViewModel vm)
        {
            // Audio Codec
            vm.AudioCodec_IsEnabled = true;

            // Stream
            vm.AudioStream_IsEnabled = true;

            // Channel
            vm.AudioChannel_IsEnabled = true;

            // Audio Quality
            vm.AudioQuality_IsEnabled = true;

            // SampleRate
            vm.AudioSampleRate_IsEnabled = true;

            // Volume
            vm.Volume_IsEnabled = true;
        }

        // -------------------------
        // Disabled
        // -------------------------
        public static void controlsDisable(ViewModel vm)
        {
            // Audio VBR
            vm.AudioVBR_IsEnabled = false;

            // Bit Depth
            vm.AudioBitDepth_IsEnabled = false;
        }
    }
}
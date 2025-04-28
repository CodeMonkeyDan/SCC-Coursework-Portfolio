//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Final Project: Escaping Death

import java.io.File;
import java.io.IOException;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.sound.sampled.LineUnavailableException;
import javax.sound.sampled.UnsupportedAudioFileException;

public class BackgroundMusic
{
	public static void PlayBackgroundMusic(String filepath)
	{
	    //find file path
	    String filePath = System.getProperty("soundFilePath", filepath);
	    
	    //try to use the file path
	    try
	    {
	        File file = new File(filePath);
	        
	        //gives error message if file path was not found
	        if (!file.exists())
	        {
	            throw new Exception("Sound file not found: " + filePath);
	        }
	        
	        AudioInputStream audioStream = AudioSystem.getAudioInputStream(file);
	        Clip clip = AudioSystem.getClip();
	        clip.open(audioStream);
	        //loops indefinitely
	        clip.loop(Clip.LOOP_CONTINUOUSLY);
	        clip.start();
	    }
	    //handles various exceptions that can occur during audio file loading and playback including:
	    //unsupported file formats, I/O errors, issues with the audio line, and interruptions during playback.
	    catch (UnsupportedAudioFileException | IOException | LineUnavailableException | InterruptedException e)
	    {
	        e.printStackTrace();
	    }
        //handle case where file is not found or can't be loaded
	    catch (Exception e)
	    {
	        System.out.println(e.getMessage());
	    }
	}
}

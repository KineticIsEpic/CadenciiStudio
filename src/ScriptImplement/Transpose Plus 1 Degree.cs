public static class Transpose_Plus_1_Degree {
    public static bool Edit( cadencii.vsq.VsqFile Vsq ) {
        for ( int i = 1; i < Vsq.Track.size(); i++ ) {
            for ( int j = 0; j < Vsq.Track.get( i ).getEventCount(); j++ ) {
                cadencii.vsq.VsqEvent item = Vsq.Track.get( i ).getEvent( j );
                if ( item.ID.type == cadencii.vsq.VsqIDType.Anote ) {
                    if ( item.ID.Note < 127 ) {
                        item.ID.Note++;
                    }
                }
            }
        }
        return true;
    }
}
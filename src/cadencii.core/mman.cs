/*
 * mman.cs
 * Copyright © 2009-2011 kbinani
 *
 * This file is part of cadencii.core.
 *
 * cadencii.core is free software; you can redistribute it and/or
 * modify it under the terms of the BSD License.
 *
 * cadencii.core is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
#if JAVA
package cadencii;

#elif __cplusplus

namespace org{
namespace kbinani{

#else

namespace cadencii
{
#endif

    public class mman
    {
#if __cplusplus
    public:
#endif

        public mman()
        {
        }

#if !JAVA
        ~mman()
        {
#if __cplusplus
            int size = mMan.size();
            for( int i = 0; i < size; i++ ){
                del( mMan.get( i ) );
            }
            mMan.clear();
            size = mManArray.size();
            for( int i = 0; i < size; i++ ){
                delArr( mManArray.get( i ) );
            }
            mManArray.clear();
#endif
        }
#endif // !JAVA

#if JAVA
        public void add( Object obj )
#elif __cplusplus
        void add( void *obj )
#else
        public void add( object obj )
#endif
        {
#if __cplusplus
            mMan.push_back( obj );
#endif
        }

#if JAVA
        public void addArr( Object obj )
#elif __cplusplus
        void addArr( void * )
#else
        public void addArr( object obj )
#endif
        {
#if __cplusplus
            mManArr.push_back( obj );
#endif
        }

#if JAVA
        public static void del( Object obj )
#elif __cplusplus
        static void del( void *obj )
#else
        public static void del( object obj )
#endif
        {
#if __cplusplus
            if( obj ){
                delete obj;
            }
#endif
        }

#if JAVA
        public static void delArr( Object obj )
#elif __cplusplus
        static void delArr( void *obj )
#else
        public static void delArr( object obj )
#endif
        {
#if __cplusplus
            if( obj ){
                delete [] obj;
            }
#endif
        }

#if __cplusplus
    private:
#endif

#if __cplusplus
        vector<void *> mMem;
        vector<void *> mMemArray;
#endif

    }

#if JAVA
#elif __cplusplus
} }
#else
}
#endif
